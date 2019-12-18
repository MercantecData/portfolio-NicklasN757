using System;
using System.Text;
using System.Net.Sockets;
using System.Net;

namespace Chat_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            //Alle de nødvendige variabler
            string message;
            bool go;
            bool isRunning = true;

            while (isRunning)
            {
                string reply = startPrint();

                if (reply == "0")
                {
                    isRunning = false;
                    Console.Clear();
                    Console.WriteLine("Programmet lukker...");
                }
                else if (reply == "1")
                {
                    Console.Clear();

                    message = "Du er ved at joine en server.";
                    go = confirmPromt(message);

                    Console.Clear();

                    if (go)
                    {
                        ClientProgram clientProgram = new ClientProgram();
                    }
                }
                else if (reply == "2")
                {
                    Console.Clear();

                    message = "Du er ved at oprette en server.";
                    go = confirmPromt(message);

                    Console.Clear();

                    if (go)
                    {
                        Server server = new Server();
                    }
                }
                else
                {
                    Console.Clear();
                }
            }
        }
        //Printer de forkellige valgmuligheder som der er i start menuen.
        public static string startPrint()
        {
            Console.WriteLine("Hej og velkommen til.");
            Console.WriteLine("0. Lukker dette program.");
            Console.WriteLine("1. Tilslut en server (Klient).");
            Console.WriteLine("2. Opret en server (Host).");
            Console.Write("Vælg hvad du vil: ");
            return Console.ReadLine();
        }
        //Spørger om brugeren er sikker på deres valg.
        public static bool confirmPromt(string message)
        {
            bool isRunning = true;
            while (isRunning)
            {
                Console.WriteLine(message);
                Console.WriteLine("Er du sikker på dette valg?");
                Console.Write("Dit svar (yes/no): ");
                string reply = Console.ReadLine().ToLower();
                if (reply == "y" || reply == "yes")
                {
                    isRunning = false;
                    return true;
                }
                else if (reply == "n" || reply == "no" || reply == "nope")
                {
                    isRunning = false;
                    return false;
                }
                Console.Clear();
            }
            return false;
        }
    }
}
