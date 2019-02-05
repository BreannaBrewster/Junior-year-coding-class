using System;
using System.Collections.Generic;
using System.Text;

namespace _Stack__Deck_of_Cards
{
    public enum Suits { Hearts, Spades, Clubs, Diamonds };
    public enum Values { Ace, Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Jack, Queen, King };
    class Card
    {
        Random rand = new Random();
        
        public Card(Suits cardSuit, Values cardValue)
        {

        }
        //public readonly Suits suit;
        //public readonly Values value;

        public void Print()
        {
            Console.WriteLine("---------------");
            Console.WriteLine("| " + Values.King + " of " + Suits.Hearts + "|");
            Console.WriteLine("---------------");
        }
    }

}
