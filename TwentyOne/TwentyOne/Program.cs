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
            // creating a new Deck called deck using our class Deck and its properties
            Deck deck = new Deck();
            // shuffles the deck 3 times
            deck.Shuffle(3);
            // loop for each card with class of Card in the deck with property of Cards
            // Prints a face and suit 52 times, one for every card
            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            // prints the number of items in our deck
            Console.WriteLine(deck.Cards.Count);
            Console.ReadLine();


            ////// EXPERIMENTATION NOTES
            ///
            ///////// Abtstract/Virtual override
            ////TwentyOneGame game = new TwentyOneGame();
            ////game.Players = new List<string>() { "Josh", "Lijah", "Gaving" };
            ////game.ListPlayers();
            ////Console.ReadLine();
            ///
            /////List<Game> games = new List<Game>();
            //// Polymorphism - abily of a class to morph into its inheritant class
            //Game game = new TwentyOneGame();
            //games.Add(game);

            ///// Object initialization
            //Card card = new Card() { Face = "King", Suit = "Spades" };
            // reassigning var deck to a shuffled version
            //deck = Shuffle(deck: deck, times: 3);// deck: and times: are just for naming, doesnt affect the code.

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
        }



    }

        //// creating an overload method also called shuffle
        //// takes 2 inputs to function and shuffles the deck multiple times
        //// number of shuffles depends on user.
        //public static Deck Shuffle(Deck deck, int times)
        //{
        //    for (int i = 0; i < times; i++)
        //    {
        //        deck = Shuffle(deck);
        //    }
        //    return deck;
        //}
    }

