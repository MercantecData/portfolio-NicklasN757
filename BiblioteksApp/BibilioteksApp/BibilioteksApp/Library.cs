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

        public Library nameAdd(Library library, string name)
        {
            library.name = name;
            return library;
        }
        public Library ownerAdd(Library library, string name)
        {
            library.owner = name;
            return library;
        }
        //Book functions
        public Library addBook(Library library, Book book)
        {
            library.books.Add(book);
            return library;
        }

        public Library removeBook(Library library, Book book)
        {
            library.books.Remove(book);
            return library;
        }

        public void loanBook(Customer customer, Book book)
        {
            customer.loanBooks.Add(book);
            books.Remove(book);
        }
        //-----------------------------------------------------//

        //Customer functions
        public Library addCustomer(Library library, Customer customer)
        {
            library.customers.Add(customer);
            return library;
        }
        public Library removeCustomer(Library library, Customer customer)
        {
            library.customers.Remove(customer);
            return library;
        }
        //-------------------------------------------------------//

        //Employer functions
        public Library addEmployer(Library library, Employer employer)
        {
            library.employers.Add(employer);
            return library;
        }
        public Library removeEmployer(Library library, Employer employer)
        {
            library.employers.Remove(employer);
            return library;
        }
        //--------------------------------------------------------//

        //Get functions 
        public string getName(Library library)
        {
            return library.name;
        }
        public string getOwner(Library library)
        {
            return library.owner;
        }
        public List<Customer> getCustomerList(Library library)
        {
            return library.customers;
        }
        public Customer getCustomer(List<Customer> customerList, int customerNum)
        {
            return customerList[customerNum];
        }
        public List<Employer> getEmployerList(Library library)
        {
            return library.employers;
        }
        public Employer getEmployer(List<Employer> employerList, int employerNum)
        {
            return employerList[employerNum];
        }
        public List<Book> getBookList(Library library)
        {
            return library.books;
        }
        public Book getBook(List<Book> bookList, int bookNum)
        {
            return bookList[bookNum];
        }
        //----------------------------------------------------//
    }
}