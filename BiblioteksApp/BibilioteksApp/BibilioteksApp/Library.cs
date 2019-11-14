using System;
using System.Collections.Generic;
using System.Text;

namespace BibilioteksApp
{
    class Library
    {
        private string name;
        private string owner;
        private List<Employer> employers = new List<Employer>();
        private List<Book> books = new List<Book>();
        private List<Customer> customers = new List<Customer>();

        public void nameAdd(string newName)
        {
            name = newName;
        }
        public void ownerAdd(string name)
        {
            owner = name;
        }

        //Book functions
        public void addBook(Book book)
        {
            books.Add(book);
        }

        public void removeBook(Book book)
        {
            books.Remove(book);
        }

        public void loanBook(Customer customer, Book book)
        {
            customer.loanBooks.Add(book);
            books.Remove(book);
        }
        //-----------------------------------------------------//

        //Customer functions
        public void addCustomer(Customer customer)
        {
            customers.Add(customer);
        }
        public void removeCustomer(Customer customer)
        {
            customers.Remove(customer);
        }
        //-------------------------------------------------------//

        //Employer functions
        public void addEmployer(Employer employer)
        {
            employers.Add(employer);
        }
        public void removeEmployer(Employer employer)
        {
            employers.Remove(employer);
        }
        //--------------------------------------------------------//

        //Get functions 
        public string getName()
        {
            return name;
        }
        public string getOwner()
        {
            return owner;
        }
        public List<Customer> getCustomerList()
        {
            return customers;
        }
        public List<Employer> getEmployerList()
        {
            return employers;
        }
        public List<Book> getBookList()
        {
            return books;
        }
        //----------------------------------------------------//
    }
}