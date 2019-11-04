using System;

namespace _8_Ball
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = { "Spørg senere", "Spørg I morgen", "Måske", "Ja", "Nej", "Spørg en dag du føler dig heldig", "Spørg din mor" };
            Random random = new Random();
            string ps = "";
            Console.WriteLine("Hvad vil du gerne spørger om?");
            //kommentar
            while (true)
            {
                int randomNum = random.Next(array.Length);
                string s = Console.ReadLine();

                if (s != string.Empty)
                {
                    if (s.ToLower() == ps)
                    {
                        Console.WriteLine("Du har lige spurgt om det!");
                        Console.WriteLine("< - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - >");
                    }
                    else
                    {
                        Console.WriteLine(array[randomNum]);
                        Console.WriteLine("< - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - >");
                        ps = s.ToLower();
                    }
                }


            }
        }
    }
}