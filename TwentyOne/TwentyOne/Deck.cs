using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class Deck
    {
        // Constructor method for Deck
        public Deck()


        {
            // adding an empty list to the property Cards
            Cards = new List<Card>();
            // loop that runs 52 times to add our cards to our deck
            for (int i = 0; i < 13; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Card card = new Card(); // creates a new card
                    card.Face = (Face)i; // adds value to Face, casting to Face, the variable i
                    card.Suit = (Suit)j; // adds value to Suit, casting to Suit, the variable j
                    Cards.Add(card); // adding the card
                }
            }
        }
        public List<Card> Cards { get; set; }

        // Creating a new method named Shuffle
        public void Shuffle(int times = 1)
        {
            for (int i = 0; i < times; i++)
            {
                List<Card> tempList = new List<Card>();
                Random random = new Random();

                // do this till there are no cards left in our deck
                while (Cards.Count > 0)
                {
                    int randomIndex = random.Next(0, Cards.Count);
                    // adding cards to temp deck
                    tempList.Add(Cards[randomIndex]);
                    // deleting cards from list of cards
                    Cards.RemoveAt(randomIndex);
                }
                this.Cards = tempList;
            }

        }
        //////
        ////// OLD CODE FOR NOTES
        //////
        ////// creating 2 lists 1 for Suits and 1 for Faces
        //////List<string> Suits = new List<string>() { "Clubs", "Hearts", "Diamonds", "Spades" };
        //////List<string> Faces = new List<string>()
        //////{
        //////    "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King", "Ace"
        //////};

        //////// Loop that goes through each item in Faces list 4 times
        //////// 1 for each item in Suits list
        //////// card is created and assigned a suit property with value suit
        //////// assigned a face prperty with value face
        //////// then adds the card to the Cards list
        //////foreach (string face in Faces)
        //////{
        //////    foreach (string suit in Suits)
        //////    {
        //////        Card card = new Card();
        //////        card.Suit = suit;
        //////        card.Face = face;
        //////        Cards.Add(card);
        //////    }
        //////}

    }
}
