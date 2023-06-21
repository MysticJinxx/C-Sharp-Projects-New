using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            string fname = "Lijah ";
            string lname = "Esk ";
            string role = "daughter";

            // Concatenates three strings, turns the string role into all uppercase
            // One way
            //string child = string.Concat(fname, lname, role.ToUpper());
            // Another way to Concatenate
            string child = fname + lname + role.ToUpper();
            
            Console.WriteLine(child);
            Console.ReadLine();

            // STRINGBUILDER
            // Builds a paragraph of text, one sentence at a time.
            StringBuilder myParagraph = new StringBuilder();

            myParagraph.Append("Hello, my name is Joshua Dishong. ");
            myParagraph.Append("\nI have a lovely wife, Gavin. ");
            myParagraph.Append("\nWe have an amazing daughter, Lijah. ");
            myParagraph.Append("\nWe also have a dog, Jay. ");
            myParagraph.Append("\nAnd finally a cat, Umbra.");

            Console.WriteLine(myParagraph);
            Console.ReadLine();
        }
    }
}
