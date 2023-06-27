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



            //////This works
            //try
            //{
            //    Console.WriteLine("OPTIONAL: please enter a second number.");
            //    int userNumTwo = Convert.ToInt32(Console.ReadLine());
            //    int answer = operations.multMethod(userNumOne, userNumTwo);
            //    Console.WriteLine(userNumOne + " times " + userNumTwo + " equals " + answer);
            //}
            //catch
            //{
            //    int answer = operations.multMethod(userNumOne);
            //    Console.WriteLine(userNumOne + " times 2 equals " + answer);
            //}

            Console.WriteLine("OPTIONAL: please enter a second number.");
            string userString = Console.ReadLine();
            if (userString == "")
            {
                
                Console.WriteLine("2 was chosen for you.");
                int answer = operations.multMethod(userNumOne);
                Console.WriteLine(userNumOne + " times " + userString + " equals " + answer);
            }
            else
            {

                int userNumTwo = Convert.ToInt32(userString);
                int answer = operations.multMethod(userNumOne, userNumTwo);
                Console.WriteLine(userNumOne + " times " + userNumTwo + " equals " + answer);
            }





            Console.ReadLine();
        }
    }
}
