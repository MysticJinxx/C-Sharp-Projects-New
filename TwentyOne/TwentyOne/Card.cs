using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class Card
    {
        // Properties of class card
        public Suit Suit { get; set; }
        public Face Face { get; set; }
    }

    // Enum
    public enum Suit
    {
        Clubs,
        Diamonds,
        Hearts,
        Spades
    }

    public enum Face
    {
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King,
        Ace
    }
    /////
    ///// NOTES
    /////
    ///// Constructor method
    //public Card()
    //{
    //    Suit = "Spades";
    //    Face = "Two";
    //}
}
