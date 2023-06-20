using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippingQuoteConsoleProject
{
    // Program that takes an inputed package weight/width/height/length, 
    // Determines if the package is too big to ship,
    // Then gives the user a quote for shipping.
    class Program
    {
        static void Main(string[] args)
        {
            // Program Start
            Console.WriteLine("Welcome to Package Express! Please follow the instuctions below.");

            // Takes user input for the weight of the package
            Console.WriteLine("Please enter the weight of the package to be shipped, in pounds.");
            int weight = Convert.ToInt32(Console.ReadLine());

            // Using if statement to determine if inputted weight is greater than 50 or not,
            // Then either continuing the program, or ending it with a message.
            if (weight > 50)
            {
                Console.WriteLine("Package is too heavy to be shipped via Package Express.");
            }
            else
            {
                // Takes user input for the width
                Console.WriteLine("What is the width of the package?");
                int width = Convert.ToInt32(Console.ReadLine());
                // height
                Console.WriteLine("What is the height?");
                int height = Convert.ToInt32(Console.ReadLine());
                // length
                Console.WriteLine("What is the length?");
                int length = Convert.ToInt32(Console.ReadLine());

                // If width + height + length is less than 50, prints the estimated total of shipping
                // If not, Ends the program
                if (width + height + length > 50)
                {
                    Console.WriteLine("Package is too big to be shipped via Package Express");
                }
                else
                {
                    // Math that multiplies the width by height by length
                    // Takes the product of above and multiplies that by weight
                    // Finally divides that by 100 to get the quote
                    int product = (width * height * length) * weight;
                    int quote = product / 100;
                    Console.WriteLine("Your estimated total for shipping this package is: $" + quote); 
                }
            }
            Console.WriteLine("Thank you, and have a great day!");

            Console.ReadLine();
        }
    }
}
