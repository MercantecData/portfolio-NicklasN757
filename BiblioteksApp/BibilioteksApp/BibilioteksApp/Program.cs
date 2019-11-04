using System;
using System.Collections.Generic;

namespace BibilioteksApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] allBooks = {"Bog 1", "Bog 2", "Bog 3", "Bog 4", "Bog 5"};
            string reply;
            bool isRunning1 = true;
            bool isRunning2 = true;
            while (isRunning1 == true) 
            { 
                Console.WriteLine("Hej, Velkommen til vores Bibiliotek.");
                Console.WriteLine();
                Console.WriteLine("0. Forlade vores Bikiliotek.");
                Console.WriteLine("1. Låne en bog.");
                Console.WriteLine("2. Forlænge en låneperiode.");
                Console.WriteLine("3. Tjekke om vi har en bestemt bog.");
                Console.WriteLine("4. Aflever en bog.");
                Console.WriteLine();
                Console.Write("Vælg hvad du vil: ");
                reply = Console.ReadLine();
                Console.Clear();

                if (reply == "0")
                {
                    Console.WriteLine("Tak fordi du gad at besøge os. Hav en god dag!");
                    isRunning = false;
                }
                else if (reply == "1") 
                {
                    Console.WriteLine("Du har valgt at låne en bog.");
                    Console.WriteLine();
                    Console.WriteLine("0. Tilbage til menuen.");
                    Console.WriteLine("1. Søge efter den.");
                    Console.WriteLine("2. Se en liste over alle vores bøger.");
                    Console.WriteLine();
                    Console.Write("Hvordan vil du finde den bog du gerne vil låne: ");
                    reply = Console.ReadLine();
                    Console.Clear();

                    while (isRunning2 == true)
                    {
                        if (reply == "0")
                        {
                            isRunning2 = false;
                        }
                        else if (reply = "1")
                        {
                            Console.Write("Skriv navnet på den bog du søger: ");
                            reply = Console.ReadLine();
                        }
                        else if (reply ="2")
                        {

                        }
                    }
                }
            }
        }
    }
}
