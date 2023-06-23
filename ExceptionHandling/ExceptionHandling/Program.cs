using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class Program
    {
        // Program that takes two user inputed numbers and divides the first one by the second one.
        // Try catch block with exceptions
        static void Main(string[] args)
        {
            try
            {
                // User Picks a number
                Console.WriteLine("Pick a number.");
                int num1 = Convert.ToInt32(Console.ReadLine());

                // User picks a second number
                Console.WriteLine("Pick a second number.");
                int num2 = Convert.ToInt32(Console.ReadLine());

                // Divides first number by second number
                Console.WriteLine("Dividing the two numbers....");
                int num3 = num1 / num2;
                Console.WriteLine(num1 + " divided by " + num2 + " equals " + num3);
                
            }
            catch (FormatException ex) // format exceptions saved in variable ex.
            {
                Console.WriteLine("Please type a whole number."); // Displays the error message to screen
                return;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("error: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }
            
        }
    }
}
