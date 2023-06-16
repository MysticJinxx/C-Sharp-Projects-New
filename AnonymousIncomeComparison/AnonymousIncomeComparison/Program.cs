using System;

namespace AnonymousIncomeComparison
{
    // Program takes 2 entered persons, prints their annual salary, and shows if person 1 makes more money than person 2
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            // Person 1 details inputed here
            Console.WriteLine("Person 1");
            Console.WriteLine("What is their hourly rate?");
            int hourlyRateOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many hours are worked each week?");
            int hoursPerWeekOne = Convert.ToInt32(Console.ReadLine());

            // Person 2 details inputed here
            Console.WriteLine("Person 2");
            Console.WriteLine("What is their hourly rate?");
            int hourlyRateTwo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many hours are worked each week?");
            int hoursPerWeekTwo = Convert.ToInt32(Console.ReadLine());

            // Person 1's Annual Salary
            Console.WriteLine("Annual salary of Person 1:");
            int personOneSalary = (hourlyRateOne * hoursPerWeekOne) * 52;
            Console.WriteLine(personOneSalary);
      
            // Person 2's Annual Salary
            Console.WriteLine("Annual salary of Person 2:");
            int personTwoSalary = (hourlyRateTwo * hoursPerWeekTwo) * 52;
            Console.WriteLine(personTwoSalary);
         
            // Comparison
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            bool isMore = personOneSalary > personTwoSalary;
            Console.WriteLine(isMore);
            Console.ReadLine();
        }
    }
}
