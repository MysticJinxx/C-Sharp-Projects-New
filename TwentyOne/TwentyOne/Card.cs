using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public struct Card
    {
        // Properties of class card
        public Suit Suit { get; set; }
        public Face Face { get; set; }
        
        public override string ToString()
        {
            return string.Format("{0} of {1}", Face, Suit);
        }
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
