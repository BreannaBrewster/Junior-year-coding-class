using System;
using System.Collections.Generic;
using System.Text;

namespace _Stack__Deck_of_Cards
{
    class Deck
    {
        
        List<Card> deck = new List<Card>();
        List<Card> discard = new List<Card>();
        List<Card> newDeck = new List<Card>();
        public Deck()
        {

            for (int suit = 0; suit < 4; suit++)
            {
                for (int value = 0; value < 13; value++)
                {
                    deck.Add(new Card((Suits)suit, (Values)value));
                }
            }
        }
        public void Shuffle()
        {
            Random rand = new Random();
            List<Card> mutatedDeck = new List<Card>();
            //foreach(Card f in deck)
            //{
                //newDeck[rand.Next(0, 50)] = f;
                //mutatedDeck.Add(f);
            //}
            //newDeck = new List<Card>();
            //foreach(Card c in mutatedDeck)
            //{
                //newDeck[rand.Next(0, 50)] = c;
                //mutatedDeck.Remove(c);
            //}
            discard = new List<Card>();
        }
        public void Draw()
        {
            Random rand = new Random();
            Card newCard = deck[rand.Next(0, deck.Count)];
            deck.Remove(newCard);
        }
        public void Discard(Card c)
        {
            newDeck.Remove(c);
            discard.Add(c);
        }
        public void PrintDiscard()
        {
            foreach(Card c in discard)
            {
                Console.WriteLine(c);
            }
        }

    }
}
