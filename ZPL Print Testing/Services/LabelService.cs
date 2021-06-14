using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using ZPL_Print_Testing.Models;

namespace ZPL_Print_Testing.Services
{
    public class LabelService : ILabelService
    {
        public void PrintLabel(string zpl, Printer printer)
        {
            try
            {
                Socket clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                clientSocket.NoDelay = true;

                IPAddress ip = IPAddress.Parse(printer.IpAddress);
                IPEndPoint ipep = new IPEndPoint(ip, printer.Port);

                clientSocket.Connect(ipep);

                byte[] zplBytes = Encoding.ASCII.GetBytes(zpl);
                clientSocket.Send(zplBytes);
                clientSocket.Close();
            }
            catch (Exception e)
            {
                // todo: mln -- Add logging.
                var message = e.Message;
                throw;
            }
        }
    }
}
