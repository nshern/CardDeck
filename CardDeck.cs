
using System.Collections.Generic;

namespace microservice
{
    public class CardDeck
    {
        public List<string> Cards { get; private set; }

        public CardDeck()
        {
            Cards = new List<string>();

            string[] suits = { "Hearts", "Diamonds", "Clubs", "Spades" };
            string[] ranks = { "Ace", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine",
 "Ten", "Jack", "Queen", "King" };

            foreach (string suit in suits)
            {
                foreach (string rank in ranks)
                {
                    Cards.Add($"{rank} of {suit}");
                }
            }

            // Add three jokers
            for (int i = 0; i < 3; i++)
            {
                Cards.Add("Joker");
            }
        }
    }
}
