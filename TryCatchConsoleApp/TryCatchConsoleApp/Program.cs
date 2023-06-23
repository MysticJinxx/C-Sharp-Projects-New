using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchConsoleApp
{
    // Program that takes a user entered number and divides each number in a list by the users number
    // Try/Catch block with exceptions that displays any error messages to the screen
    class Program
    {
        static void Main(string[] args)
        {
            
            // Try/Catch block
            try
            {
                // List used by the program
                List<decimal> numList = new List<decimal>() { 250m, 4000m, 2395m, 1044m, 24093m, 100000m };
                // Displays the list for the user. 
                Console.WriteLine("Here is a list of whole numbers: ");
                foreach (decimal n in numList)
                {
                    Console.WriteLine(n);
                }

                // Asks the user for a number
                Console.WriteLine("Please enter a number to divide each number in the list by.");
                decimal userNum = Convert.ToDecimal(Console.ReadLine());

                // Loop that takes each decimal in list,
                // Divides it by the number the user entered,
                // And displays the result to screen

                foreach (decimal num in numList)
                {
                    
                    // number in list divided by user number saved in i
                    decimal i = num / userNum;
                    Console.WriteLine(num + " divided by " + userNum + " equals " + i);
                }
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Error: Cannot divide by zero");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please enter a number");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
