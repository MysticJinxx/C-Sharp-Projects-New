using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branching
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite number?");
            int faveNum = Convert.ToInt32(Console.ReadLine());

            string result = faveNum == 12 ? "You have an awesome favorite number" : "You do not have an awesome favorite number";

            Console.WriteLine(result);

            //int roomTemp = 70;

            //Console.WriteLine("Hi, What is your name?");
            //string name = Console.ReadLine();

            //Console.WriteLine("Hi, " + name + ", what is the temperature where you are?");
            //int currentTemp = Convert.ToInt32(Console.ReadLine());

            //if (currentTemp == roomTemp)
            //{
            //    Console.WriteLine("It is exactly room temperature.");
            //}
            //else if (currentTemp > roomTemp)
            //{
            //    Console.WriteLine("It is warmer than room temperature");
            //}
            //else if (roomTemp > currentTemp)
            //{
            //    Console.WriteLine("It is cooler than room temperature.");
            //}
            //else
            //{
            //    Console.WriteLine("Something went wrong.");
            //}

            //int currentTemp = 70;
            //int roomTemp = 70;

            //string comparisonResult = currentTemp == roomTemp ? "It is room temperature." : "It is not room temperature.";

            //Console.WriteLine(comparisonResult);

            //if (currentTemp == roomTemp)
            //{
            //    Console.WriteLine("It is exactly room temperature.");
            //}
            //else if (currentTemp > roomTemp)
            //{
            //    Console.WriteLine("It is currently warmer than room temperature.");
            //}
            //else if (roomTemp > currentTemp)
            //{
            //    Console.WriteLine("It is currently cooler than room temperature.");
            //}
            //else
            //{
            //    Console.WriteLine("It is currently not room temperature");
            //}
            Console.ReadLine();
        }
    }
}
