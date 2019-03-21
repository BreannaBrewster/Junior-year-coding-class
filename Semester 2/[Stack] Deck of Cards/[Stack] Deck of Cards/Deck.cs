using System;
using System.Collections.Generic;
using System.Text;

namespace _Stack__Deck_of_Cards
{
    class Deck
    {
        Random rand = new Random();
        public List<Card> Cards { get; set; }
        List<Card> discard = new List<Card>();
        public Deck()
        {
            foreach (Suits suit in Enum.GetValues(typeof(Suits)))
            {
                foreach (Values value in Enum.GetValues(typeof(Values)))
                {
                    Cards.Add(new Card(suit, value));
                }
            }
        }


        public void Shuffle()
        {
            Random rand = new Random();
            List<Card> mutatedDeck = new List<Card>();
            foreach(Card c in Cards)
            {
                mutatedDeck.Add(c);
            }
            //for(int deckLength= mutatedDeck.Count; deckLength > 1; deckLength--)
            //{
            //    var temp = list[i];
            //    list[i] = list[j];
            //    list[j] = temp;

            //}
            discard = new List<Card>();
        }
        public void Draw()
        {
            Random rand = new Random();
            //Card newCard = deck[rand.Next(0, deck.Count)];
            //deck.Remove(newCard);
        }
        public void Discard(Card c)
        {
            //newDeck.Remove(c);
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
