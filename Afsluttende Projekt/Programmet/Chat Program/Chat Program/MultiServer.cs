using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace Chat_Program
{
    class Server
    {
        public List<TcpClient> clients = new List<TcpClient>();
        public Server()
        {
            consoleColor consoleColor = new consoleColor();

            Console.Clear();

            IPAddress ip = IPAddress.Any;
            int port = portCheck();

            TcpListener listener = new TcpListener(ip, port);
            listener.Start();

            Console.WriteLine("Opretter server vent venligst...");
            Console.Clear();
            consoleColor.green();
            Console.WriteLine("Server oprettet på port: " + port);
            consoleColor.gray();
            Console.WriteLine("Skriv den første besked.....");
            Console.WriteLine("<--------------->-|-|-<--------------->");

            AcceptClients(listener);

            bool isRunning = true;
            while (isRunning)
            {

                Console.Write("You: ");
                string text = Console.ReadLine();
                byte[] buffer = Encoding.UTF8.GetBytes(text);
                foreach (TcpClient client in clients)
                {
                    client.GetStream().Write(buffer, 0, buffer.Length);
                }
            }
        }
        public async void AcceptClients(TcpListener listener)
        {
            bool isRuning = true;
            while (isRuning)
            {
                TcpClient client = await listener.AcceptTcpClientAsync();
                clients.Add(client);
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
                Console.WriteLine("\nClient: " + text);
                Console.Write("You: ");
            }
        }
        //Tjekker om du har skrevet en gyldig port ind.
        private int portCheck()
        {
            consoleColor consoleColor = new consoleColor();
            bool isRunning = true;
            while (isRunning) 
            { 
                Console.WriteLine("Skriv hvad for en port din server skal være på.");
                Console.WriteLine("Det skal være en port mellem 49151 og 65535.");
                Console.Write("Dit valg: ");
                string port = Console.ReadLine();

                if (port == "test")
                {
                    return 50757;
                }

                int intPort;
                bool result = Int32.TryParse(port, out intPort);

                if (result)
                {
                    if (intPort > 49151 && intPort <= 65535)
                    {
                        isRunning = false;
                        Console.Clear();
                        return intPort;
                    }
                    else
                    {
                        Console.Clear();
                        consoleColor.red();
                        Console.WriteLine("Forkert port nummer. Husk du kun kan kun bruge porte mellem 49454 og 65535.");
                        consoleColor.gray();
                    }
                }
                else
                {
                    Console.Clear();
                    consoleColor.red();
                    Console.WriteLine("Udgyldig port nummer! Prøv igen...");
                    consoleColor.gray();
                }
            }
            return 65535;
        }
    }
}
