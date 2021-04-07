using System;
using System.Collections.Concurrent;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;
using ZPL_Print_Testing.Handlers;
using ZPL_Print_Testing.Models;
using ZPL_Print_Testing.ViewModels;

namespace ZPL_Print_Testing.Servers
{
    public class Server
    {
        private TcpListener server;
        private ConcurrentBag<Task> tasks;
        private CancellationToken token;
        private ConcurrentQueue<Message> messages;
        private MainViewModel viewModel;


        public Server(MainViewModel vm, CancellationToken token, ConcurrentBag<Task> tasks, ConcurrentQueue<Message> messages)
        {
            this.viewModel = vm;
            IPAddress localAddr = IPAddress.Parse(viewModel.IpAddress);
            this.server = new TcpListener(localAddr, viewModel.Port);
            this.tasks = tasks;
            this.token = token;
            this.messages = messages;
            this.server.Start();
            this.StartListener();
        }

        //public Server(string ip, int port)
        //{
        //    IPAddress localAddr = IPAddress.Parse(ip);
        //    server = new TcpListener(localAddr, port);
        //    server.Start();
        //    StartListener();
        //}

        public void StartListener()
        {
            using (token.Register(() => server.Stop()))
            {

                //Task t;
                try
                {
                    while (true)
                    {
                        Console.WriteLine("Waiting for a connection...");
                        TcpClient client = server.AcceptTcpClient();
                        client.ReceiveTimeout = 60;
                        client.SendTimeout = 60;
                        Console.WriteLine("Connected!");
                        Task t = Task.Run(() =>
                        {
                            var handler = new ClientHandler(viewModel, tasks, token, client, messages);
                            handler.Handle();
                        }, token);

                        tasks.Add(t);
                        
                    }
                }
                catch (SocketException e)
                {
                    Console.WriteLine("SocketException: {0}", e);
                    server.Stop();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            
        }
    }
}
