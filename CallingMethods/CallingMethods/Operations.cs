using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethods
{
    class Operations
    {
        public int SumMethod(int addition)
        {
            int sum = addition + 50;
            return sum;
        }

        public int ProdMethod(int multiplication)
        {
            int product = multiplication * 8;
            return product;
        }

        public int QuotMethod(int division)
        {
            int quotient = division / 2;
            return quotient;
        }
    }
}
