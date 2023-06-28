using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethods
{
    static class Program
    {
        static void Main(string[] args)
        {
            // Instantiate class
            Operation operation = new Operation();

            // Method 1
            // User input
            Console.WriteLine("Please enter a number that will be divided by 2.");
            // int.Parse is a way to replace Convert.ToInt32
            int userNum = int.Parse(Console.ReadLine());

            operation.outMethod(userNum);
            Console.ReadLine();

            // Method with output parameters
            // User input
            Console.WriteLine("Please enter a number that will be multiplied by 10, then divided by 2");
            string userString = Console.ReadLine();
            // Int32.TryParse is a way to replace Convert.ToInt32
            Int32.TryParse(userString, out int userNum2);

            operation.outMethod(userNum2, out int result1, out int result2);
            Console.ReadLine();
        }
    }
}
