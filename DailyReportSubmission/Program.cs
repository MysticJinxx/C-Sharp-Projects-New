using System;


namespace DailyReportSubmission
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("The Tech Academy.");
            Console.WriteLine("Student Daily Report.");

            // Name
            Console.WriteLine("What is your name?");
            string yourName = Console.ReadLine();

            // Course
            Console.WriteLine("What Course are you on?");
            string yourCourse = Console.ReadLine();

            // Page Number
            Console.WriteLine("What Page Number are you on?");
            string pageNum = Console.ReadLine();
            int pageNumber = Convert.ToInt32(pageNum);
            

            // Help?
            Console.WriteLine("Do you need help with anything?");
            Console.WriteLine("Please answer \"true\" or \"false\"");
            Console.ReadLine();

            // Positive Experiences
            Console.WriteLine("Were there any positive experiences you'd like to share?");
            Console.WriteLine("Please give specifics.");
            Console.ReadLine();

            // Feedback
            Console.WriteLine("Is there any other feedback you'd like to provide?");
            Console.WriteLine("Please be specific.");
            Console.ReadLine();

            // Hours Studied
            Console.WriteLine("How many hours did you study today?");
            string hoursStudied = Console.ReadLine();
            int hoursStudy = Convert.ToInt32(hoursStudied);

            // Submission
            Console.WriteLine("Thank you for you answers. An instructior will respond to this shortly. Have a great day!");
            Console.ReadLine();
        }
    }
}
