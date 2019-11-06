using System;
using System.Collections.Generic;
using System.Text;

namespace BibilioteksApp
{
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
}
