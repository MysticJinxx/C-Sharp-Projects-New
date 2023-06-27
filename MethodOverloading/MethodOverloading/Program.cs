using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Operations operations = new Operations();

            // Method overload one
            float answerOne = operations.opMethod(500f);
            Console.WriteLine("500 minus 125 is equal to " + answerOne);
         

            // Method overload two
            int answerTwo = operations.opMethod(478);
            Console.WriteLine("478 multiplied by 5 is equal to " + answerTwo);
           

            // Method overload three
            string answerThree = operations.opMethod("5");
            Console.WriteLine("\"5\" plus 1000 is equal to " + answerThree);
            Console.ReadLine();
        }
    }
}
