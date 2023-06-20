using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TernaryOperatorChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 20;
            int num2 = 10;

            string result = num1 <= num2 ? "num1 is less than or equal to num2" : "num1 is NOT less than or equal to num2";
            Console.WriteLine(result);
            Console.ReadLine();

        }
    }
}
