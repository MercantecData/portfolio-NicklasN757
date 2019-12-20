using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace Chat_Program
{
    class ClientProgram
    {
        public ClientProgram()
        {
            consoleColor consoleColor = new consoleColor();
            TcpClient client = new TcpClient();
            bool isRunning = true;

            //Console.Clear();

            int port = portCheckClient();
            Console.Clear();
            IPAddress ip = ipCheckClient();
            IPEndPoint endPoint = new IPEndPoint(ip, port);

            Console.Clear();

            Console.WriteLine("Forbinder til server...");
            try
            {
                client.Connect(endPoint);
            }
            catch (SocketException)
            {
                Console.Clear();
                consoleColor.red();
                Console.WriteLine("Kunne ikke forbinde til serveren tjek om du har brugt den rigtige port og ip.");
                consoleColor.gray();
                Console.Write("Tryk ennter for at fortsætte...");
                Console.ReadLine();
                Console.Clear();
                return;
            }
            
            Console.Clear();
            consoleColor.green();
            Console.WriteLine("Forbinelse oprettet til server.");
            Console.WriteLine("Port: " + port);
            Console.WriteLine("Ip: " + ip);
            consoleColor.gray();
            Console.WriteLine("Skriv din første besked.....");
            Console.WriteLine("<--------------->-|-|-<--------------->");

            while (isRunning)
            {
                NetworkStream stream = client.GetStream();
                ReceiveMessage(stream);

                Console.Write("You: ");

                string text = Console.ReadLine();
                byte[] buffer = Encoding.UTF8.GetBytes(text);
                stream.Write(buffer, 0, buffer.Length);

                if (text == "/ouit")
                {
                    isRunning = false;
                    client.Close();
                    Console.WriteLine("<--------------->-|-|-<--------------->");
                    Console.WriteLine("Du har forladt samtalen...");
                    Console.WriteLine("Tryk enter for at gå videre...");
                    Console.ReadLine();
                    Console.Clear();
                    return;
                }
            }
            
            client.Close();
        }
        public async void ReceiveMessage(NetworkStream stream)
        {
            byte[] buffer = new byte[256];
            while (true)
            {
                try
                {
                    int numberOfBytesRead = await stream.ReadAsync(buffer, 0, 256);
                    string receivedMessage = Encoding.UTF8.GetString(buffer, 0, numberOfBytesRead);
                    Console.Write("\nUser: " + receivedMessage);
                }
                catch (System.IO.IOException)
                {
                    return;
                }
                catch (System.ObjectDisposedException)
                {
                    return;
                }
            }
        }
        //Tjekker om du har skrevet en gyldig port ind.
        private int portCheckClient()
        {
            consoleColor consoleColor = new consoleColor();
            bool isRunning = true;
            while (isRunning)
            {
                Console.WriteLine("Skriv hvad for en port du vil bruge.");
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
        private IPAddress ipCheckClient()
        {
            consoleColor consoleColor = new consoleColor();
            bool isRunning = true;

            while (isRunning)
            {
                Console.WriteLine("Skriv den ip du vil forbinde til.");
                Console.Write("Dit valg: ");
                string ip = Console.ReadLine();

                if (ip == "test")
                {
                    return IPAddress.Parse("127.0.0.1");
                }

                IPAddress stringIp;
                bool result = IPAddress.TryParse(ip, out stringIp);
                if (result)
                {
                    isRunning = false;
                    return stringIp;
                }
                else
                {
                    Console.Clear();
                    consoleColor.red();
                    Console.WriteLine("Ugyldig ip. Prøv igen...");
                    consoleColor.gray();
                }
            }
            return IPAddress.Parse("127.0.0.1");
        }
        //Ryder sidste linje
        public void ClearLastLine()
        {
            Console.SetCursorPosition(0, Console.CursorTop - 1);
            Console.WriteLine(new string(' ', Console.BufferWidth));
            Console.SetCursorPosition(0, Console.CursorTop - 1);
        }
    }
}