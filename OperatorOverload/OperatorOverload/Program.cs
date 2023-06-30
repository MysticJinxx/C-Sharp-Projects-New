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
            Employee employee1 = new Employee() { Id = 01, Name = "Joshua" };
            Employee employee2 = new Employee() { Id = 02, Name = "Gavin" };

            Employee.Equals(employee1, employee2);
            Console.ReadLine();
        }
    }
}
