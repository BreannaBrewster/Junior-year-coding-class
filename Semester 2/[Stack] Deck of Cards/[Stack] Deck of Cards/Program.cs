using System;

namespace _Stack__Deck_of_Cards
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck myDeck1 = new Deck();
            Deck myDeck2 = new Deck();
            myDeck1.Shuffle();
            myDeck2.Shuffle();
            for(int i=0; i<3; i++)
            {
                Console.WriteLine(myDeck1);
            }
        }
    }
}
