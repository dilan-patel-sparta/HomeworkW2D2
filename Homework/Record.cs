using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work
{
    using System.IO;
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

            Console.WriteLine("Several files are being created below:");
            File.Create("Image" + args[0] + ".png");
            File.Create("Image" + args[1] + ".png");
            File.Create("Image" + args[2] + ".png");
            Console.ReadLine();

            Method methodExample = new Method();
            String myString = methodExample.ReverseString("Please reverse me!");
            Console.WriteLine(myString);
        }
        int numberOfEmployeers()
        {
            int totalEmployees = 0;
            return totalEmployees;
        }

    }
}
