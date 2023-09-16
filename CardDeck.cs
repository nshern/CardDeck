namespace microservice
{
    public enum Suit
    {
        Hearts,
        Diamonds,
        Clubs,
        Spades,
        Joker
    }

    public enum Rank
    {
        Ace = 1,
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
        Joker
    }

    public class Card
    {
        public Suit Suit { get; set; }
        public Rank Rank { get; set; }
    }

    public class CardDeck
    {
        public List<Card> Cards { get; set; }

        public CardDeck()
        {
            Cards = new List<Card>();

            foreach (Suit suit in Enum.GetValues(typeof(Suit)))
            {
                if (suit != Suit.Joker)
                {
                    foreach (Rank rank in Enum.GetValues(typeof(Rank)))
                    {
                        if (rank != Rank.Joker)
                        {
                            Cards.Add(new Card { Suit = suit, Rank = rank });
                        }
                    }
                }
            }

            // Add three jokers
            for (int i = 0; i < 3; i++)
            {
                Cards.Add(new Card { Suit = Suit.Joker, Rank = Rank.Joker });
            }
        }
    }
}
