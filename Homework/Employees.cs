using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Work
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