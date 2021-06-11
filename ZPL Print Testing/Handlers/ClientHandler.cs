using System;
using System.Collections.Concurrent;
using System.IO;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ZPL_Print_Testing.Models;
using ZPL_Print_Testing.ViewModels;
using ZPL_Print_Testing.WebClients;

namespace ZPL_Print_Testing.Handlers
{
    public class ClientHandler
    {

        private ConcurrentBag<Task> tasks;
        private ConcurrentQueue<Message> messages;
        private CancellationToken token;
        private TcpClient client;
        private MainViewModel viewModel;

        public ClientHandler(MainViewModel viewModel, ConcurrentBag<Task> tasks, CancellationToken token, TcpClient client, ConcurrentQueue<Message> messages)
        {
            this.viewModel = viewModel;
            this.tasks = tasks;
            this.token = token;
            this.client = client;
            this.messages = messages;
        }

        public void Handle()
        {
            var networkStream = client.GetStream();
            var reader = new StreamReader(networkStream, Encoding.ASCII);
            var writer = new StreamWriter(networkStream, Encoding.ASCII) { AutoFlush = true };
            try
            {
                string line = "";
                while (!string.IsNullOrWhiteSpace(line = reader.ReadToEnd()))
                {
                    if (token.IsCancellationRequested)
                    {
                        client.Close();
                        break;
                    }

                    //writer.WriteLine("You typed: " + line);
                    ImageHttpClient httpClient = new ImageHttpClient(viewModel);
                    var image = httpClient.Send(line);

                    if (image != null)
                    {
                        var m = new Message("Image received", image, line);
                        messages.Enqueue(m);
                    }

                    line = null;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: {0}", e.ToString());
                client.Close();
                throw e;
            }
        }
    }
}

