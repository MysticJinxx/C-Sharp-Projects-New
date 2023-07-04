using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Struct myStruct = new Struct();
            myStruct.Amount = 2000 / 10;

            Console.WriteLine(myStruct.Amount);
            Console.ReadLine();
        }
    }
}
