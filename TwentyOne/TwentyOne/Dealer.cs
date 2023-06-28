using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            Console.WriteLine(Deck.Cards.First().ToString() + "\n"); // Prints the first card
            Deck.Cards.RemoveAt(0); // Removes index 0 - the item we just added to the Hand
        }
    }
}
