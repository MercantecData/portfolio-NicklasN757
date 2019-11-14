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

            Console.WriteLine("Velkommen til " + library.getName(library) + ".");
            Console.WriteLine("Eget af " + library.getOwner(library) + ".");
            Console.WriteLine();

            printBooks(library);

            Console.WriteLine();

            printCustomer(library);

            Console.WriteLine();

            printEmployer(library);

            Console.WriteLine();
            library.loanBook(library.getCustomer(library.getCustomerList(library), 0), library.getBook(library.getBookList(library),0));
            Console.WriteLine("Du har valgt at låne bogen: " + library.getCustomer(library.getCustomerList(library), 0).loanBooks[0].name);

            Console.WriteLine();

            printBooks(library);
            
        }

        public static Library adder(Library library)
        {
            library.addBook(library, new Book("Morgensjernen", "Lone Kærgård", "08.09.15", "Action", 234));
            library.addBook(library, new Book("Den Lille Drage", "Søren Bogorm", "01.03.02", "Børnebog", 25));
            library.addBook(library, new Book("Den Sorte regn", "Peter Sørensen", "02.06.10", "Krimi", 111));

            library.addCustomer(library, new Customer("Nick", 19, 2598));
            library.addCustomer(library, new Customer("Jack", 2, 6941));
            library.addCustomer(library, new Customer("Mikkel", 30, 6486));

            library.addEmployer(library, new Employer("Mia", 62, 185, 66666, "Bikbitikar"));
            library.addEmployer(library, new Employer("Karen", 50, 185, 68481, "Bikbitikar"));
            library.addEmployer(library, new Employer("Sofia", 42, 215, 68438, "Leder"));

            library.nameAdd(library, "Søndergård Biblioteket");
            library.ownerAdd(library ,"Nick");

            return library;
        }
        public static void printBooks(Library library)
        {
            Console.WriteLine("Her er en liste over vores udvalg af bøger:");
            Console.WriteLine("<>------------------------------------<>");

            int i = 0;
            while (i < library.getBookList(library).Count)
            {
                Console.WriteLine(library.getBookList(library)[i].name);
                Console.WriteLine("Skrevet af: " + library.getBookList(library)[i].author + ".");
                Console.WriteLine("<>------------------------------------<>");
                i += 1;
            }
        }
        public static void printCustomer(Library library)
        {
            Console.WriteLine("Her er en liste over alle vores kunder:");
            int s = 0;
            while (s < library.getCustomerList(library).Count)
            {
                Console.WriteLine(library.getCustomerList(library)[s].name);
                s += 1;
            }
        }
        public static void printEmployer(Library library)
        {
            Console.WriteLine("Her er en list over vore medarbejder");
            int n = 0;
            while (n < library.getEmployerList(library).Count)
            {
                Console.WriteLine(library.getEmployerList(library)[n].name);
                n += 1;
            }
        }
    }
}
