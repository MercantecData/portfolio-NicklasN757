using System;
using System.Collections.Generic;
using System.Linq;

namespace BibilioteksApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();

            library = adder(library);

            Console.WriteLine("Velkommen til " + library.name + ".");
            Console.WriteLine("Eget af " + library.owner + ".");
            Console.WriteLine();

            printBooks(library);

            Console.WriteLine();

            printCustomer(library);

            Console.WriteLine();

            printEmployer(library);
            
        }

        public static Library adder(Library library)
        {
            library.books.Add(new Book("Morgensjernen", "Lone Kærgård", "08.09.15", "Action", 234));
            library.books.Add(new Book("Den Lille Drage", "Søren Bogorm", "01.03.02", "Børnebog", 25));
            library.books.Add(new Book("Den Sorte regn", "Peter Sørensen", "02.06.10", "Krimi", 111));

            library.customer.Add(new Customer("Nick", 19, 2598));
            library.customer.Add(new Customer("Jack", 2, 6941));
            library.customer.Add(new Customer("Mikkel", 30, 6486));

            library.employer.Add(new Employer("Mia", 62, 185, 66666, "Bikbitikar"));
            library.employer.Add(new Employer("Karen", 50, 185, 68481, "Bikbitikar"));
            library.employer.Add(new Employer("Sofia", 42, 215, 68438, "Leder"));

            library.name = "Mathias Bio lol";
            library.owner = "Mathias";

            return library;
        }
        public static void printBooks(Library library)
        {
            Console.WriteLine("Vores udvalg af bøger består af:");
            Console.WriteLine("<>------------------------------------<>");

            int i = 0;
            while (i < library.books.Count)
            {
                Console.WriteLine(library.books[i].name);
                Console.WriteLine("Skrevet af: " + library.books[i].author + ".");
                Console.WriteLine("<>------------------------------------<>");
                i += 1;
            }
        }
        public static void printCustomer(Library library)
        {
            Console.WriteLine("Her er en liste over alle vores kunder:");
            int s = 0;
            while (s < library.customer.Count)
            {
                Console.WriteLine(library.customer[s].name);
                s += 1;
            }
        }
        public static void printEmployer(Library library)
        {
            Console.WriteLine("Her er en list over vore medarbejder");
            int n = 0;
            while (n < library.employer.Count)
            {
                Console.WriteLine(library.employer[n].name);
                n += 1;
            }
        }
    }
}
