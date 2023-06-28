using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Operations operations = new Operations();

            Console.WriteLine("Enter a number to be multiplied by 10.");
            int numOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a number to be displayed.");
            int numTwo = Convert.ToInt32(Console.ReadLine());


            operations.voidMethod(50, 20);
            operations.voidMethod(paraOne: numOne, paraTwo: numTwo);
            Console.ReadLine();
        }
    }
}
