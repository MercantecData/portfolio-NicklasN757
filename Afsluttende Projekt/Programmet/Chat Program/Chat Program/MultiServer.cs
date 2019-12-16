using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Sockets;
using System.Net;

namespace Chat_Program
{
    class MultiServer
    {
        public List<TcpClient> Clients = new List<TcpClient>();
        public MultiServer()
        {
            IPAddress ip = IPAddress.Parse("127.0.0.1");
            int port = 13356;
            TcpListener listener = new TcpListener(ip, port);
            listener.Start();

            AcceptClients(listener);

            bool isRunning = true;
            while (isRunning)
            {
                Console.Write("Write message: ");
                string text = Console.ReadLine();
                byte[] buffer = Encoding.UTF8.GetBytes(text);

                foreach(TcpClient client in Clients)
                {
                    client.GetStream().Write(buffer, 0, buffer.Length);
                }
            }

        }
        public async void AcceptClients(TcpListener listener)
        {
            bool isRunning = true;
            while (isRunning)
            {
                TcpListener client = await listener.AcceptTcpClientAsync();
                Clients.Add(client);
                NetworkStream stream = client.GetStream();
                ReceiveMessages(stream);
            }
        }
        public async void ReceiveMessages(NetworkStream stream)
        {
            byte[] buffer = new byte[256];
            bool isRunning = true;
            while (isRunning)
            {
                int read = await stream.ReadAsync(buffer, 0, buffer.Length);
                String text = Encoding.UTF8.GetString(buffer, 0, read);
                stream.Write(buffer, 0, buffer.Length);
            }
        }
    }
}
