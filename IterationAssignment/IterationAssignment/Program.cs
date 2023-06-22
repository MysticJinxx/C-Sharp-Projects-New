using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IterationAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //// PART ONE
            //// One-dimensional array of strings.
            //string[] peopleArray = { "Joshua", "Gavin", "Lijah", "Andy", "Jacob" };
            //peopleArray.ToList().ForEach(Console.WriteLine);

            //// Asks the user for input
            //Console.WriteLine("Please write an action phrase one of the above people might do \nExample: 'name' is going on a run.");
            //string userPhrase = Console.ReadLine();

            //// Loop that iterates through each string in the array,
            //// adds the user's text input to the end of each string,
            //// then prints off each string on a seperate line.
            //for (int i = 0; i < peopleArray.Length; i++)
            //{
            //    peopleArray[i] = peopleArray[i] + " " + userPhrase; 
            //    Console.WriteLine(peopleArray[i]);
            //}
            //Console.ReadLine();


            //// PART TWO
            //// create an infinite loop
            //int x = 0;
            //while (x <= 10)
            //{
            //    Console.WriteLine("This is an infinite loop");
            //    x++; // fixed infinite loop by having x increment up to 10
            //}
            //Console.ReadLine();


            //// PART THREE
            //// Loop using < as a comparison operator
            //int num = 0;
            //while (num < 10)
            //{
            //    Console.WriteLine("num is now : " + num);
            //    num++;
            //}
            //Console.ReadLine();

            //// Loop using <= as a comparison operator
            //for (int j = 0; j <= 10; j++)
            //{
            //    Console.WriteLine("j is now : " + j);
            //}
            //Console.ReadLine();

            //// PART FOUR
            //// List of strings with unique items
            //List<string> groceryList = new List<string>() { "milk", "eggs", "bread", "cheese", "beans", "chicken", "beef", "ice cream", "potatoes", "yogurt" };

            //// User inputs text to search for in the list.
            //Console.WriteLine("Please type a item to search for in the grocery list.");
            //string itemSearched = Console.ReadLine();
            //bool isInList = false;
            //// Loop that iterates through the list,
            //// then displays the index of the item the user searched for.
            //// Text is printed if user inputs text that isn't in the list.
            //// Loop stops executing once a match has been found.
            //do
            //{


            //    foreach (string grocery in groceryList)
            //    {
            //        if (grocery.Contains(itemSearched))
            //        {
            //            int indexGrocery = groceryList.IndexOf(grocery);
            //            isInList = true;
            //            Console.WriteLine(itemSearched + " is index number " +indexGrocery);
            //        }
            //    }
            //    if (!isInList)
            //    {
            //        Console.WriteLine(itemSearched + " doesn't appear to be in the grocery list \nPlease enter a new item.");
            //        itemSearched = Console.ReadLine();
            //    }
            //} while (!isInList);
            //Console.ReadLine();

            // PART SIX
            // List of strings with at least 2 identical strings
            List<string> carList = new List<string>() { "Ford", "Chevrolet", "GMC", "Buick", "Volkswagen", "Chevrolet", "Jaguar", "Volkswagen" };


            // foreach loop that evaluates each item in the list,
            // displays a message with the string and whether or not -
            // it has already appeared in the list.

            // lists to store
            List<string> list = new List<string>();
            List<string> duplicateList = new List<string>();
            
            // possible way to solve part 6
            //for (int i = 0; i < carList.Count; i++) 
            //{
            //    for (int j = i + 1; j < carList.Count; j++)
            //    {
            //        if (carList[j] == carList[i])
            //        {
            //            if (!list.Contains(carList[i]))
            //            {
            //                list.Add(carList[i]);
            //            }
            //        }
            //    }
            //}

            //foreach (string X in list)
            //{
            //    Console.WriteLine(X);
            //}
            //Console.ReadLine();

            // Possible way to solve part 6
            foreach (string car in carList)
            {
                if (!list.Contains(car))
                {
                    list.Add(car);
                }
                else
                {
                    duplicateList.Add(car);
                }
            }
            duplicateList.ForEach(Console.WriteLine);
            Console.ReadLine();
        }
    }
}
