using System;
using System.Collections.Generic;
using System.Linq;

namespace BibilioteksApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] allBooks = {"Bog 1", "Bog 2", "Bog 3", "Bog 4", "Bog 5"};
            List<string> currentBookList = new List<string>();
            currentBookList.AddRange(allBooks);

            string reply1;
            string reply2;
            bool isRunning1 = true;
            bool isRunning2 = true;
            bool isRunning3 = true;

            while (isRunning1) 
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
                reply1 = Console.ReadLine();
                Console.Clear();

                if (reply1 == "0")
                {
                    Console.WriteLine("Tak fordi du gad at besøge os. Hav en god dag!");
                    isRunning1 = false;
                }
                else if (reply1 == "1") 
                {
                    while (isRunning2)
                    {
                        Console.WriteLine("Du har valgt at låne en bog.");
                        Console.WriteLine();
                        Console.WriteLine("0. Tilbage til menuen.");
                        Console.WriteLine("1. Søge efter den.");
                        Console.WriteLine("2. Se en liste over alle vores bøger.");
                        Console.WriteLine();
                        Console.Write("Hvordan vil du finde den bog du gerne vil låne: ");
                        reply1 = Console.ReadLine();
                        Console.Clear();

                        if (reply1 == "0")
                        {
                            isRunning2 = false;
                        }
                        else if (reply1 == "1")
                        {
                            while (isRunning3) { 
                                Console.Write("Skriv navnet på den bog du søger: ");
                                reply2 = Console.ReadLine();
                                Console.Clear();

                                if (allBooks.Contains(reply2))
                                {
                                    if (currentBookList.Contains(reply2))
                                    {
                                        Console.WriteLine("Gode nyheder! Vi har bogen du søger og du har mulighed for låne den");
                                        Console.Write("Vil du det? Y/N");
                                        reply2 = Console.ReadLine();

                                        if (reply2.ToLower() != "y")
                                        {

                                        }
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Beklager men vi har desvære ikke den bog du søger.");
                                    Console.Write("Vil du prøve igen? Y/N: ");
                                    reply2 = Console.ReadLine();
                                    Console.Clear();

                                    if (reply2.ToLower() != "y")
                                    {
                                        isRunning3 = false;
                                    }

                                }
                            }
                        }
                        else if (reply1 == "2")
                        {

                        }
                    }
                }
            }
        }
    }
}
