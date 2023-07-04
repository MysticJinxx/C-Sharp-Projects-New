using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingEnums
{
    class Program
    {
        static void Main(string[] args)
        {
            // User input
            Console.WriteLine("Please enter the current day of the week. \nMake sure the first letter is capitalized!");
            string currentDay = Console.ReadLine();

            try
            {
                // Assign the value to a variable of the enum data type we created.
                // This works
                Console.WriteLine(Enum.Parse(typeof(DayOfWeek), currentDay));
                // This also works
                DayOfWeek day = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), currentDay);
                Console.WriteLine(day);
                Console.ReadLine();
            }
            catch
            {
                Console.WriteLine("Please enter an actual day of the week");
                currentDay = Console.ReadLine();
            }
        }
    }
}
