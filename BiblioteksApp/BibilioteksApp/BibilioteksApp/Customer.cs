using System;
using System.Collections.Generic;
using System.Text;

namespace BibilioteksApp
{
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
