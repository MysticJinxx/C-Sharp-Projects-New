using System;
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
            //// Instantiate Employye object with type 'string'
            //Employee<string> stringThings = new Employee<string>();
            //// Instantiate Employee object wiht type 'int'
            //Employee<int> intThings = new Employee<int>();
            //// Assign a list of strings as value of Things
            //stringThings.Things = new List<string>() { "Computer", "Stapler", "Paperclips", "Chair" };
            //// Assign a list of integers as value of Things
            //intThings.Things = new List<int>() { 1, 2, 3, 4 };

            //// Loop prints all Things to screen
            //stringThings.Things.ForEach(i => Console.WriteLine("{0}", i));
            //intThings.Things.ForEach(i => Console.WriteLine("{0}", i));

            /////
            ///// OVERLOAD OPERATOR
            /////
            //Employee employee1 = new Employee() { Id = 01, Name = "Joshua" };
            //Employee employee2 = new Employee() { Id = 02, Name = "Gavin" };
            
            // Both of these WriteLines do the same thing
            //Console.WriteLine("Do the 2 employee's id numbers match? " + Employee.Equals(employee1, employee2))
            //Console.WriteLine("Do the 2 employee's id numbers match? {0} ", employee1 == employee2); // overloading the == operator
            /////
            ///// /OVERLOAD OPERATOR
            /////
            Console.ReadLine();
        }
    }
}
