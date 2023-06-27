using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    public class Operations
    {
        // Takes a decimal number and subtracts 125
        public decimal opMethod(decimal subtraction)
        {
            decimal decDifference = subtraction - 125;
            int difference = Convert.ToInt32(decDifference);
            return difference;
        }

        // Takes an integer and multiplies it by 5
        public int opMethod(int multiplication)
        {
            int product = multiplication * 5;
            return product;
        }

        // Takes a string, converts it to a integer and then adds it, if possible
        public string opMethod(string addition)
        {
            string stringSum = addition + 1000;
            int sum = Convert.ToInt32(stringSum);
            return sum;
        }

        


    }
}
