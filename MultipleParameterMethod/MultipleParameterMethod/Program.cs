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

            ///////This also works
            Console.WriteLine("OPTIONAL: please enter a second number.");
            string userString = Console.ReadLine();

            // loop used to decide what math to perform
            if (userString == "")
            {
                // if the user doesnt enter anything for the second number
                Console.WriteLine("2 was chosen for you.");
                int answer = operations.multMethod(userNumOne);
                Console.WriteLine(userNumOne + " times " + userString + " equals " + answer);
            }
            else
            {
                // if the user enters a number the second time
                int userNumTwo = Convert.ToInt32(userString);
                int answer = operations.multMethod(userNumOne, userNumTwo);
                Console.WriteLine(userNumOne + " times " + userNumTwo + " equals " + answer);
            }





            Console.ReadLine();
        }
    }
}
