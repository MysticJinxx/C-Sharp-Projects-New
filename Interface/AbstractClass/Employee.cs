using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public class Employee : Person, IQuittable
    {
        public override void SayName()
        {
            Console.WriteLine("Name: " + FirstName + LastName);
        }

        public void Quit()
        {
            Console.WriteLine(FirstName + LastName + "has just quit their job.");
        }
    }
}
