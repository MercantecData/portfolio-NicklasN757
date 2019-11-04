using System;

namespace BibilioteksApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hej, Velkommen til vores Bibiliotek.");
            Console.WriteLine("1. Låne en bog.");
            Console.WriteLine("2. Forlænge en låneperiode.");
            Console.WriteLine("3. Tjekke om vi har en bestemt bog.");
            Console.WriteLine("4. Aflever en bog.");
            Console.Write("Vælg hvad du vil: ");
            string reply = Console.ReadLine();
        }
    }
}
