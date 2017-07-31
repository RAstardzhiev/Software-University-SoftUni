namespace _03.Card_Power.Models
{
    using System;
    using Enums;

    public class Card : IComparable<Card>
    {
        private Rank rank;
        private Suit suit;
        private int power;

        public Card(Rank rank, Suit suit)
        {
            this.rank = rank;
            this.suit = suit;
            this.power = (int)this.rank + (int)this.suit;
        }

        public Rank Rank => this.rank;

        public Suit Suit => this.suit;

        public int CompareTo(Card other)
        {
            return this.power - other.power;
        }

        public override string ToString()
        {
            return $"Card name: {this.rank} of {this.suit}; Card power: {this.power}";
        }
    }
}
