using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Operations operations = new Operations();

            Console.WriteLine("Please enter a number you want 50 added to. \nYour original number will then be multiplied by 8, \nFinally your original number will be divided by two");
            int userNum = Convert.ToInt32(Console.ReadLine());

            int answerOne = operations.SumMethod(userNum);
            int answerTwo = operations.ProdMethod(userNum);
            int answerThree = operations.QuotMethod(userNum);
            Console.WriteLine(userNum + " plus 50 equals: " + "\n" + answerOne);
            Console.WriteLine(userNum + " multiplied by 8 equals: " + "\n" + answerTwo);
            Console.WriteLine(userNum + " divided by 2 equals: " + "\n" + answerThree);
            Console.ReadLine();
        }
    }
}
