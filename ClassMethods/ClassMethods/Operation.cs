using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethods
{
    public static class Operation
    {
        public void outMethod(int num1)
        {
            int quotient = num1 / 2;
            Console.WriteLine(num1 + " divided by 2 equals " + quotient);
        }

        public void outMethod(int num2, out int result1, out int result2)
        {
            result1 = num2 * 10;
            result2 = result1 / 2;
            Console.WriteLine(num2 + " multiplied by 10 equals " + result1);
            Console.WriteLine(result1 + " divided by 2 equals " + result2);
        }
    }
}
