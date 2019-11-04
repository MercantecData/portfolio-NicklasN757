using System;
using System.Linq;

namespace allInOneApp
{
    class Program
    {
        static void Main(string[] args)
        {
            static void arrayApp() {
                Console.WriteLine("Du har valgt 1.");
                Console.Write("Skriv størelsen på dit array: ");

                string arraySize = Console.ReadLine();
                
                if (arraySize != string.Empty)
                {
                    int result = 0;
                    bool tjeck = int.TryParse(arraySize, out result);
                   if (tjeck)
                    {
                        Console.WriteLine("Du har valgt at lave et array der er " + result);
                        string[] myArray = new string[result];
                        Console.WriteLine();

                        int i = 0;
                        while (i < myArray.Length)
                        {
                            Console.Write("Skrive det tal som skal være på array´eds " + i + " plads: ");
                            myArray[i] = Console.ReadLine();
                            i += 1;
                        }
                        Console.WriteLine();
                        Console.WriteLine("Dit array består af: ");
                        int s = 0;
                        while (s < myArray.Length)
                        {
                            Console.WriteLine(myArray[s]);
                            s += 1;
                        }
                    }
                }

               
            }
            static void tællerApp()
            {
                Console.WriteLine("Du har valgt 2.");
                Console.Write("Vælg vilket tal dit array skal tælle til: ");
                string arraySize = Console.ReadLine();

                if (arraySize != string.Empty)
                {
                    int result;
                    bool tjeck = int.TryParse(arraySize, out result);
                    if (tjeck)
                    {
                       string[] myArray = new string[result];
                        string s = "0";
                        int i = 0;
                        while (i < result)
                        {
                            s += 1;
                            myArray[i] = s;
                            i += 1;
                        }
                        Console.WriteLine();
                        int e = 0;
                        while (e < result)
                        {
                            Console.WriteLine(myArray[e]);
                            e += 1;
                        }
                    }
                }
                
            }
            static void højsteTalApp()
            {
                Console.WriteLine("Du har valgt 3.");
                Console.Write("Skriv størelsen på dit array: ");
                string arraySize = Console.ReadLine();

                if (arraySize != string.Empty)
                {
                    int result;
                    bool tjeck = int.TryParse(arraySize, out result);
                    if (tjeck)
                    {
                        string[] myArray = new string[result];
                        Console.WriteLine();
                        int i = 0;
                        while (i < myArray.Length)
                        {
                            Console.Write("Skrive den værdi som skal være på array´eds " + i + " plads: ");
                            myArray[i] = Console.ReadLine();
                            i += 1;
                        }
                        Console.WriteLine();
                        Console.Write("Den største værdi i dit array er: ");
                        Console.WriteLine(myArray.Max());
                    }
                }
                        
            }
            static void soteringApp()
            {
                Console.WriteLine("Du har valgt 4.");
                Console.Write("Skriv størelsen på dit array: ");
                string arraySize = Console.ReadLine();

                if (arraySize != string.Empty)
                {
                    int result;
                    bool tjeck = int.TryParse(arraySize, out result);
                    if (tjeck)
                    {
                        string[] myArray = new string[result];
                        Console.WriteLine();

                        int i = 0;
                        while (i < myArray.Length)
                        {
                            Console.Write("Skrive det tal som skal være på array´eds " + i + " plads: ");
                            myArray[i] = Console.ReadLine();
                            i += 1;
                        }
                        Array.Sort(myArray);

                        Console.WriteLine();
                        Console.WriteLine("Dit sorteret array ser sådan her ud: ");
                        int s = 0;
                        while (s < myArray.Length)
                        {
                            Console.WriteLine(myArray[s]);
                            s += 1;
                        }
                    }
                }
                       
            }

            bool run = true;
            while (run)
            {
                Console.WriteLine();
                Console.WriteLine("Vælg hvad du vil. Skriv det tal som passer til det program du gerne vil bruge:");
                Console.WriteLine();
                Console.WriteLine("0. Stopper dette program");
                Console.WriteLine("1. Array app");
                Console.WriteLine("2. Tæller app");
                Console.WriteLine("3. Højste tal i array app");
                Console.WriteLine("4. Sorterings af et array app");
                Console.Write("Hvad vælger du?: ");

                string choice = (Console.ReadLine());

                if (choice != string.Empty)
                {
                     //Lukker programmet
                    if (choice == "0")
                    {
                        run = false;
                    }

                    //Array app. Du bestemmer hvor stor et array skal være og så fylder du det ud.
                    else if (choice == "1")
                    {
                        Console.Clear();
                        arrayApp();
                    }
                    //TællerApp. Du skriver hvor lang et array skal være og så tæller den fra det mindste til det største.
                    else if (choice == "2")
                    {
                        Console.Clear();
                        tællerApp();
                    }
                    //Højste tal i array app. Du skriver hvor stor et array skal være, bagefter skriver du en masse tilfældge tal og så printer den det største til consolen.
                    else if (choice == "3")
                    {
                        Console.Clear();
                        højsteTalApp();
                    }
                    //Array soterings app. Du laver et tilfældig array og så sortere den det bagefter.
                    else if (choice == "4")
                    {
                        Console.Clear();
                        soteringApp();
                    }
                }
            }
        }
    }
}
