using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LoggingTextFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            // Asks the user for a number
            Console.WriteLine("Welcome to my program!\nWe are going to log a number to a txt file!\nPlease enter a number.");
            int userNum = int.Parse(Console.ReadLine());
            // Logs that number to a text file.
            File.WriteAllText(@"C:\Users\disho\OneDrive\Documents\GitHub\C-Sharp-Projects-New\LoggingTextFiles\Log\log.txt", Convert.ToString(userNum));
            // Prints the text file back to the user
            string readText = File.ReadAllText(@"C:\Users\disho\OneDrive\Documents\GitHub\C-Sharp-Projects-New\LoggingTextFiles\Log\log.txt");
            Console.WriteLine("The number you entered was " + readText);
            Console.ReadLine();
        }
    }
}
