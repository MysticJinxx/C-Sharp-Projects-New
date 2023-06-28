using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInheritance
{
    class Person
    {
        // Properties
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Method which writes a persons full name to the console
        // format - Name: [full name]
        public void SayName()
        {
            Console.WriteLine("Name: " + FirstName + LastName);
        }
    }
}
