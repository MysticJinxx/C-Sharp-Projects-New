using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhileStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            // WHILE LOOP
            // 20 sided die roll.
            Random rnd = new Random();
            int i = 0;

            while (i == 0)
            {
                Console.WriteLine("You rolled a " + rnd.Next(20));
                break;
            }
            Console.ReadLine();



            // DO WHILE LOOP
            Console.WriteLine("What is my birth month?");
            string month = Console.ReadLine();
            bool guess = month == "February";

            do
            {
                switch (month)
                {
                    case "January":
                        Console.WriteLine("Close, try again");
                        month = Console.ReadLine();
                        break;

                    case "February":
                        Console.WriteLine("Correct!");
                        month = Console.ReadLine();
                        guess = true;
                        break;
                    case "March":
                        Console.WriteLine("Close, try again");
                        month = Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("Try again");
                        month = Console.ReadLine();
                        break;

                }
            }
            while (!guess);
        }  
    }
}
