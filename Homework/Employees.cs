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
        private bool isPermenant; // Returns true if permenant employee, false if temporary.
        private string department; // Department employee works in.
        private string firstName; // Employee first name.
        private string lastName; // Employee last name.

        private void setId(int num)
        {
            id = num;
        }
        private int getId()
        {
        return id;
        }
        private void setIsPermentant(bool employmentStatus)
        {
            isPermenant = employmentStatus;
        }
        private bool getIsPermenant()
        {
            return isPermenant;
        }
        private void setDepartment(string dept)
        {
            department = dept;
        }
        private string getDepartment()
        {
            return department;
        }
        private void setFirstName(string fName)
        {
            firstName = fName;
        }
        private string getFirstName()
        {
            return firstName;
        }
        private void setLastName(string lName)
        {
            lastName = lName;
        }
        private string getLastName()
        {
            return lastName;
        }
    }
    class Developer : Employee
    {
        public int noOfLanguages;
        public string stack;
        public bool agileExperience;

        private void setNoOfLanguages(int languages)
        {
            noOfLanguages = languages;
        }
        private int getNoOfLanguages()
        {
            return noOfLanguages;
        }
        private void setStack(string st)
        {
            stack = st;
        }
        private string getLastName()
        {
            return stack;
        }
        private void setAgileExperience(bool hasExperience)
        {
            agileExperience = hasExperience;
        }
        private bool getAgileExperience()
        {
            return agileExperience;
        }
    }
    class Accountant : Employee
    {
        public string accountingQualification;

        private void setAccountingQualification(string qualification)
        {
            accountingQualification = qualification;
        }
        private string getAccountingQualification()
        {
            return accountingQualification;
        }
    }
}