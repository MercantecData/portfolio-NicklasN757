using System;
using System.Collections.Generic;
using System.Text;

namespace BibilioteksApp
{
    class Library
    {
        public string name;
        public string owner;
        public Employer employer;
        public List<Book> books;
        public Customer customer;

        List<Book> listOffBooks = new List<Book>();

        public List<Book> addBook(Book book, List<Book> books)
        {
            books.Add(book);
            return books;
        }
        public List<Book> removeBook(int bookNum, List<Book> books)
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
        public string pages; 
    }
    class Employer
    {
        public string name;
        public int age;
        public int salary;
        public string employmentDate;
        public int employmentID;
        public string rank;
    }
    class Customer
    {
        public string name;
        public int age;
        public int customerID; 
    }
}
