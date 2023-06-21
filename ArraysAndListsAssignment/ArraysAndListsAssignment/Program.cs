using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndListsAssignment
{
    class Program
    {
        static void Main()
        {
            //// ONE-DIMENSIONAL ARRAY OF STRINGS
            //string[] familyArray = { "Joshua", "Gavin", "Lijah", "Jay", "Umbra" };

            //    //this displays the whole array on the screen
            //    //familyArray.ToList().ForEach(Console.WriteLine);

            //// Asks user to select index of the Array,
            //Console.WriteLine("Please select an index between 0 and " + (familyArray.Length - 1) + " to display info from familyArray.");
            //int choice = Convert.ToInt32(Console.ReadLine());
            //bool stringChoice = false;

            //// Displays choice on screen,
            //// Tells user to redo if selected index doesn't exist.
            //do
            //{
            //    if (choice <= familyArray.Length - 1)
            //    {
            //        Console.WriteLine(familyArray[choice]);
            //        stringChoice = true;
            //        Console.ReadLine();
            //    }
            //    else
            //    {
            //        Console.WriteLine("You didn't follow instructions! \nPlease select an index between 0 and " + (familyArray.Length - 1) + " to display info from familyArray.");
            //        choice = Convert.ToInt32(Console.ReadLine());
            //    }
            //} while (!stringChoice);


            //// ONE-DIMENSIONAL ARRAY OF INTEGERS
            //int[] numArray = { 30, 28, 10, 6, 2 };

            //// Asks user to select an index of the Array.
            //Console.WriteLine("Please select an indext between 0 and " + (numArray.Length - 1) + " to display info from numArray.");
            //int choice2 = Convert.ToInt32(Console.ReadLine());
            //bool intChoice = false;

            //do
            //{
            //    if (choice2 <= numArray.Length - 1)
            //    {
            //        Console.WriteLine(numArray[choice2]);
            //        intChoice = true;
            //        Console.ReadLine();
            //    }
            //    else
            //    {
            //        Console.WriteLine("You didn't follow instructions! \nPlease select an index between 0 and " + (numArray.Length - 1) + " to display info from familyArray.");
            //        choice2 = Convert.ToInt32(Console.ReadLine());
            //    }
            //} while (!intChoice);


            // LIST OF STRINGS
            List<string> dogList = new List<string>() { "Husky", "Lab", "Dachshund", "Great Pyrenees", "Samoyed", "Malamute" };

            // Asks user to select an index of the list
            Console.WriteLine("Please select an index between 0 and " + (dogList.Count - 1) + " to display the dog breed in that index.");
            int choice3 = Convert.ToInt32(Console.ReadLine());
            bool listChoice = false;

            do
            {
                if (choice3 <= dogList.Count - 1)
                {
                    Console.WriteLine(dogList[choice3]);
                    listChoice = true;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("You didn't follow instructions! \nPlease select an index between 0 and " + (dogList.Count - 1) + " to display the dog breed in that index.");
                    choice3 = Convert.ToInt32(Console.ReadLine());
                }
            } while (!listChoice);
        }
    }
}
