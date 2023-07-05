using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TwentyOne
{
    public class Dealer
    {
        public string Name { get; set; }
        public Deck Deck { get; set; }
        public int Balance { get; set; }

        public void Deal(List<Card> Hand)
        {
            Hand.Add(Deck.Cards.First()); // Adds the first card to Hand
            string card = string.Format(Deck.Cards.First().ToString() + "\n");
            Console.WriteLine(card); // Prints the first card
            // writing the card to alog everytime its dealt
            using (StreamWriter file = new StreamWriter(@"C:\Users\disho\OneDrive\Documents\GitHub\C-Sharp-Projects-New\Log\log.txt", true))
            {
                file.WriteLine(card);
            }
                Deck.Cards.RemoveAt(0); // Removes index 0 - the item we just added to the Hand

        }
    }
}
