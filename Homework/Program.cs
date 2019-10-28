using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Classes
{
    class Employee
    {
        private int id; // Employee ID.
        public bool isPermenant; // Returns true if permenant employee, false if temporary.
        public string department; // Department employee works in.
        public string firstName; // Employee first name.
        public string lastName; // Employee last name.
    }
    class Developer : Employee
    {
        public int noOfLanguages;
        public string stack;
        public bool agileExperience;
    }
    class Accountant : Employee
    {
        public string accountingQualification;
    }
}

namespace Work
{
    using Classes;
    class Program
    {
        static void Main(string[] args)
        {
            Developer John = new Developer();
            John.firstName = "John";
            John.lastName = "Smith";
            John.isPermenant = false;
            John.department = "IT";
            John.noOfLanguages = 6;
            John.stack = "Full Stack";
            John.agileExperience = true;

            Accountant Matt = new Accountant();
            Matt.firstName = "Matt";
            Matt.lastName = "Jackson";
            Matt.isPermenant = true;
            Matt.department = "Accounting";
            Matt.accountingQualification = "ACCA";
        }
    }
}