using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DateTimeConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Current Date/Time Is: " + DateTime.Now);
            Console.WriteLine("Please enter a number.");
            double userNum = double.Parse(Console.ReadLine());
            Console.WriteLine("{0} + {1} hour(s) = {2}", DateTime.Now, userNum, DateTime.Now.AddHours(userNum));

            Console.ReadLine();
        }
    }
}
