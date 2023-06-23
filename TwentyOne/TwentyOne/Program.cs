using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            ////////// if we wanted to do every card one at a time, this could work
            ////////// adding a new list to the property Cards of our new deck
            ////////deck.Cards = new List<Card>();

            ////////// creating a new Card called cardOne using our class Card and its properties
            ////////Card cardOne = new Card();
            ////////// assigning values to class Card properties
            ////////cardOne.Face = "Queen";
            ////////cardOne.Suit = "Spades";

            ////////// adding cardOne to our list
            ////////deck.Cards.Add(cardOne);

            ////////Console.WriteLine(cardOne.Face + " of " + cardOne.Suit);


            // creating a new Deck called deck using our class Deck and its properties
            Deck deck = new Deck();
            // reassigning var deck to a shuffled version
            deck = Shuffle(deck);
            // loop for each card with class of Card in the deck with property of Cards
            // Prints a face and suit 52 times, one for every card
            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            // prints the number of items in our deck
            Console.WriteLine(deck.Cards.Count);
            Console.ReadLine();
        }

        // Creating a new method named Shuffle
        public static Deck Shuffle (Deck deck)
        {
            List<Card> tempList = new List<Card>();
            Random random = new Random();

            // do this till there are no cards left in our deck
            while (deck.Cards.Count > 0)
            {
                int randomIndex = random.Next(0, deck.Cards.Count);
                // adding cards to temp deck
                tempList.Add(deck.Cards[randomIndex]);
                // deleting cards from list of cards
                deck.Cards.RemoveAt(randomIndex);
            }
            deck.Cards = tempList;
            return deck;

        }
    }
}
