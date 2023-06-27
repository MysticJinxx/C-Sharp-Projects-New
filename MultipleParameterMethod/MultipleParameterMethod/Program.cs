using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleParameterMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Operations operations = new Operations();

            Console.WriteLine("This program will take an entered number and a second optional number, \nand multiply them together.");
            Console.WriteLine("Please enter a number.");
            int userNumOne = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("OPTIONAL: please enter a second number.");
            string userString = Console.ReadLine();

            Int32.TryParse(userString, out int userNumTwo);


            int answer = operations.multMethod(userNumOne, userNumTwo);

            Console.WriteLine(userNumOne + " times " + userNumTwo + " equals " + answer);
            Console.ReadLine();
        }
    }
}
