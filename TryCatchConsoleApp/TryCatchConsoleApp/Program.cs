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
                List<int> numList = new List<int>() { 250, 4000, 2395, 1044, 24093, 100000 };
                // Displays the list for the user. 
                Console.WriteLine("Here is a list of whole numbers: ");
                foreach (int n in numList)
                {
                    Console.WriteLine(n);
                }

                // Asks the user for a number
                Console.WriteLine("Please enter a number to divide each number in the list by.");
                int userNum = Convert.ToInt32(Console.ReadLine());

                // Loop that takes each int in list,
                // Divides it by the number the user entered,
                // And displays the result to screen

                foreach (int num in numList)
                {
                    
                    // number in list divided by user number saved in i
                    int i = num / userNum;
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
