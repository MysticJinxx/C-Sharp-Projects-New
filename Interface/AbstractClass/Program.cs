using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            // Polymorphed object of IQuittable
            IQuittable employeeQuit = new Employee();

            // Employee object for SayName() method.
            Employee employee = new Employee();

            // Giving values to FirstName and LastName
            employee.FirstName = "Sample ";
            employee.LastName = "Student";

            
            employee.SayName();
            employeeQuit.Quit();
            Console.ReadLine();
        }
    }
}
