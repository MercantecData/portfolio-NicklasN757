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
}
