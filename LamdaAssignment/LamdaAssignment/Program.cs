using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LamdaAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employees> empList = new List<Employees>()
            {
                new Employees() { ID = 1, FirstName = "Joe", LastName = "Bob"},
                new Employees() { ID = 2, FirstName = "Joe", LastName = "Dirt"},
                new Employees() { ID = 3, FirstName = "Gavin", LastName = "Buzzard"},
                new Employees() { ID = 4, FirstName = "Joshua", LastName = "Dishong"},
                new Employees() { ID = 5, FirstName = "Lijah", LastName = "Esk"},
                new Employees() { ID = 6, FirstName = "Billy", LastName = "Bob"},
                new Employees() { ID = 7, FirstName = "Jon", LastName = "Bellion"},
                new Employees() { ID = 8, FirstName = "Mr.", LastName = "Clean"},
                new Employees() { ID = 9, FirstName = "Spongebob", LastName = "Squarepants"},
                new Employees() { ID = 10, FirstName = "Garrosh", LastName = "Hellscream"}
            };


            ////Displays empList
            //Console.WriteLine("List of employees: ");
            //foreach (var employee in empList)
            //{
            //    Console.WriteLine(employee.FirstName + " " + employee.LastName + " " + employee.ID);
            //}

            

            //// using a foreach loop, created new list of all employees with FirstName == "Joe"
            //var sameFirstName = new List<Employees>();
            //Console.WriteLine("Foreach list of employees named Joe:");
            //foreach (Employees employee in empList)
            //{
            //    if (employee.FirstName == "Joe")
            //    {
            //        sameFirstName.Add(new Employees
            //        {
            //            ID = employee.ID,
            //            FirstName = employee.FirstName,
            //            LastName = employee.LastName
            //        });
            //    }
            //}
            //foreach (Employees employees in sameFirstName)
            //{
            //    Console.WriteLine(employees.FirstName + " " + employees.LastName + " " + employees.ID);
            //}

            


            //// Lambda expression for above loop
            //var sameFirstNameLambda = empList.FindAll(x => x.FirstName == "Joe");
            //Console.WriteLine("Lambda list of employees named Joe:");
            //foreach (var person in sameFirstNameLambda)
            //{
            //    Console.WriteLine(person.FirstName + " " + person.LastName + " " + person.ID);
            //}

            // Lambda expression for list of employees with id > 5
            var greaterThanList = empList.FindAll(i => i.ID > 5);
            foreach (var id in greaterThanList)
            {
                Console.WriteLine(id.ID + " " + id.FirstName + " " + id.LastName);
            }

            Console.ReadLine();
        }
    }
}
