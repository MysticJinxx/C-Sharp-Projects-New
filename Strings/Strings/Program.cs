using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //string name = "Joshua";
            //string quote = "The man said, \"Hello, Joshua\"";
            //string fileName = @"C:\Users\Joshua";

            //bool trueOrFalse = name.Contains("s");
            //trueOrFalse = name.EndsWith("s");

            //int length = name.Length;

            //name = name.ToLower();

            //Console.WriteLine(name);
            //Console.WriteLine(quote);
            //Console.WriteLine(fileName);
            //Console.WriteLine(trueOrFalse);
            //Console.WriteLine(length);

            StringBuilder sb = new StringBuilder();

            sb.Append("My name is Joshua");

            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}
