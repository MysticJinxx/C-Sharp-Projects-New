using System;


namespace ConsoleAppChallenge
{
    // Program to do some math operations
    class Program
    {
        static void Main()
        {
            // Takes an entered number and multiplies it by 50
            Console.WriteLine("Enter an integer");
            int multNum = Convert.ToInt32(Console.ReadLine());
            int product = multNum * 50;
            Console.WriteLine(multNum + " times 50 is " + product);
            Console.ReadLine();

            // Takes an entered number and adds 25 to it
            Console.WriteLine("Enter a number");
            double addNum = Convert.ToDouble(Console.ReadLine());
            double sum = addNum + 25;
            Console.WriteLine(addNum + " plus 25 is " + sum);
            Console.ReadLine();

            // Takes an entered number and divides it by 12.5
            Console.WriteLine("Enter a number");
            double divNum = Convert.ToDouble(Console.ReadLine());
            double quotient = divNum / 12.5;
            Console.WriteLine(divNum + " divided by 12.5 is " + quotient);
            Console.Read();

            // Takes an entered number and compares it to 50
            Console.WriteLine("Enter a number");
            int boolNum = Convert.ToInt32(Console.ReadLine());
            bool greaterThan = boolNum > 50;
            Console.WriteLine(greaterThan);
            Console.ReadLine();

            // Takes an entered number and finds the remainder if divided by 7
            Console.WriteLine("Enter a number");
            int modNum = Convert.ToInt32(Console.ReadLine());
            int remainder = modNum % 7;
            Console.WriteLine(modNum + " divdided by 7, has a remainder of " + remainder);
            Console.ReadLine();
        }
    }
}
