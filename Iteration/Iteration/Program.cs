using System;
using System.Collections.Generic;

namespace Iteration
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] testScores = { 98, 99, 84, 70, 82, 34, 91, 90, 94 };

            //// i starts at 0, if i is less than the length of the array testScores
            //// increment
            //for (int i = 0; i < testScores.Length; i++)
            //{
            //    // if i (current index) is greater than 82, WriteLine
            //    if (testScores[i] > 82) 
            //        {
            //            Console.WriteLine("Pasing test score: " + testScores[i]);
            //        }
            //}
            //Console.ReadLine();

            //// Lists
            //string[] names = { "Josh", "Erik", "Daniel", "Adam" };
            //// Displays all names in the list
            //for (int j = 0; j < names.Length; j++)
            //{
            //    Console.WriteLine(names[j]);
            //}

            //// Displays Josh
            //for (int j = 0; j < names.Length; j++)
            //{
            //    if (names[j] == "Josh")
            //    {
            //        Console.WriteLine(names[j]);
            //    }
            //}
            //Console.ReadLine();

            //// Iteration through a list
            //List<int> testScores = new List<int>();
            //testScores.Add(98);
            //testScores.Add(99);
            //testScores.Add(81);
            //testScores.Add(72);
            //testScores.Add(70);

            //foreach (int score in testScores)
            //{
            //    if (score > 85)
            //    {
            //        Console.WriteLine("Passing test score: " + score);
            //    }
            //}
            //Console.ReadLine();

            //List<string> names = new List<string>() { "Josh", "Erik", "Adam", "Daniel" };

            //foreach (string name in names)
            //{
            //    Console.WriteLine(name);
            //}
            //Console.ReadLine();

            // Moving scores from one list to another if they are above 85.
            List<int> testScores = new List<int>() { 98, 99, 12, 74, 23, 99 };
            List<int> passingScores = new List<int>();

            foreach (int scores in testScores)
            {
                if (scores > 85)
                {
                    passingScores.Add(scores);
                }
            }

            Console.WriteLine(passingScores.Count);
            Console.ReadLine();
        }
    }
}
