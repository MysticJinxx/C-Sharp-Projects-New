using System;


namespace BooleanLogicCarInsurance
{
    // Program which determines if the user is qualifed for car insurance.
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Car Insurance Qualification Program");
            // AGE
            Console.WriteLine("What is your age?");
            int ageNum = Convert.ToInt32(Console.ReadLine());

            // DUI
            Console.WriteLine("Have you ever had a DUI? (Please enter 'true' or 'false')");
            bool dui = Convert.ToBoolean(Console.ReadLine());

            // Speeding Tickets
            Console.WriteLine("How many speeding tickets have you recieved?");
            int ticNum = Convert.ToInt32(Console.ReadLine());

            // Qualification Results
            Console.WriteLine("Are you qualified?");
            Console.WriteLine(ageNum >= 15 && dui == false && ticNum <= 3);
            Console.ReadLine();
        }
    }
}
