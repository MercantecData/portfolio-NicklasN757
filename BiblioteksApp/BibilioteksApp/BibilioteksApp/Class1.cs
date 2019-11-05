using System;
using System.Collections.Generic;
using System.Text;

namespace BibilioteksApp
{
    class Library
    {
        public string name;
        public string owner;
        public List<Employer> employer = new List<Employer>();
        public List<Book> books = new List<Book>();
        public List<Customer> customer = new List<Customer>();

        public List<Book> addBook(Book book)
        {
            books.Add(book);
            return books;
        }

        public List<Book> removeBook(int bookNum)
        {
            books.RemoveAt(bookNum);
            return books;
        }
    }
    class Book
    {
        public string name;
        public string author;
        public string releaseDate;
        public string theme;
        public int pages;

        public Book(string name, string author, string releaseDate, string theme, int pages)
        {
            this.name = name;
            this.author = author;
            this.releaseDate = releaseDate;
            this.theme = theme;
            this.pages = pages;
        }
    }
    class Employer
    {
        public string name;
        public int age;
        public int salary;
        public int employmentID;
        public string rank;

        public Employer(string name, int age, int salary, int employmentID, string rank)
        {
            this.name = name;
            this.age = age;
            this.salary = salary;
            this.employmentID = employmentID;
            this.rank = rank;
        }
    }
    class Customer
    {
        public string name;
        public int age;
        public int customerID;

        public Customer(string name, int age, int customerID)
        {
            this.name = name;
            this.age = age;
            this.customerID = customerID;
        }
    }
}
