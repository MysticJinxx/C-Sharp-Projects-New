﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverload
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> stringThings = new Employee<string>();
            Employee<int> intThings = new Employee<int>();
            stringThings.Things = new List<string>() { "Computer", "Stapler", "Paperclips", "Chair" };
            intThings.Things = new List<int>() { 1, 2, 3, 4 };

            stringThings.Things.ForEach(i => Console.WriteLine("{0}", i));
            intThings.Things.ForEach(i => Console.WriteLine("{0}", i));

            /////
            ///// OVERLOAD OPERATOR
            /////
            //Employee employee1 = new Employee() { Id = 01, Name = "Joshua" };
            //Employee employee2 = new Employee() { Id = 02, Name = "Gavin" };

            //Console.WriteLine("Do the 2 employee's id numbers match? " + Employee.Equals(employee1, employee2));
            /////
            ///// /OVERLOAD OPERATOR
            /////
            Console.ReadLine();
        }
    }
}
