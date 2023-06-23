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
            // creating 2 lists 1 for Suits and 1 for Faces
            List<string> Suits = new List<string>() { "Clubs", "Hearts", "Diamonds", "Spades" };
            List<string> Faces = new List<string>()
            {
                "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King", "Ace"
            };

            // Loop that goes through each item in Faces list 4 times
            // 1 for each item in Suits list
            // card is created and assigned a suit property with value suit
            // assigned a face prperty with value face
            // then adds the card to the Cards list
            foreach (string face in Faces)
            {
                foreach (string suit in Suits)
                {
                    Card card = new Card();
                    card.Suit = suit;
                    card.Face = face;
                    Cards.Add(card);
                }
            }
        }
        public List<Card> Cards { get; set; }
    }
}
