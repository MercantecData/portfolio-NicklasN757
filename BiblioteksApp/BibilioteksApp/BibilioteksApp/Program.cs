using System;
using System.Collections.Generic;
using System.Linq;

namespace BibilioteksApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("Den Lille Drage", "Søren Bogorm", "01.03.02", "Børnebog", 25);
            Book book2 = new Book("Den Sorte regn", "Peter Sørensen", "02.06.10","Krimi", 111);
            Book book3 = new Book("Morgensjernen", "Lone Kærgård", "08.09.15", "Action", 234);

            Customer customer1 = new Customer("Nick", 19, 2598);
            Customer customer2 = new Customer("Jack", 2, 6941);
            Customer customer3 = new Customer("Mikkel", 30, 6486);

            Employer employer1 = new Employer("Mia", 62, 185, 66666, "Bikbitikar");
            Employer employer2 = new Employer("Karen", 50, 185, 68481, "Bikbitikar");
            Employer employer3 = new Employer("Sofia", 42, 215, 68438, "Leder");

            Library library = new Library(); 
            
            library.books.Add(book1);
            library.books.Add(book2);
            library.books.Add(book3);

            library.customer.Add(customer1);
            library.customer.Add(customer2);
            library.customer.Add(customer3);
            
            library.employer.Add(employer1);
            library.employer.Add(employer2);
            library.employer.Add(employer3);

            library.name = "Mathias Bio lol";
            library.owner = "Mathias";

            Console.WriteLine("Velkommen til " + library.name + ".");
            Console.WriteLine("Eget af " + library.owner + ".");
            Console.WriteLine();
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
            Console.WriteLine();
            Console.WriteLine("Her er en liste over alle vores kunder:");
            int s = 0;
            while (s < library.customer.Count)
            {
                Console.WriteLine(library.customer[s].name);
                s += 1;
            }
            Console.WriteLine();
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
