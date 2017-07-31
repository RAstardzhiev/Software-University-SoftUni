namespace _03.Card_Power.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Enums;
    using Models;

    public class CardGame
    {
        private string winner;
        private Card winningCard;
        private HashSet<Card> cardsInPlayers;

        public CardGame()
        {
            this.cardsInPlayers = new HashSet<Card>();
        }

        public void Run()
        {
            var firstPlayer = Console.ReadLine();
            var secondPlayer = Console.ReadLine();

            this.GetCards(firstPlayer);
            this.GetCards(secondPlayer);

            Console.WriteLine($"{this.winner} wins with {this.winningCard.Rank} of {this.winningCard.Suit}.");
        }

        private void GetCards(string player)
        {
            for (int i = 0; i < 5; i++)
            {
                var cardDetails = Console.ReadLine().Split();
                var rankName = cardDetails[0];
                var suitName = cardDetails[2];

                Rank rank;
                var isRankValid = Enum.TryParse(rankName, out rank);
                Suit suit;
                var isSuitkValid = Enum.TryParse(suitName, out suit);

                if (!isRankValid || !isSuitkValid)
                {
                    Console.WriteLine("No such card exists.");
                    i--;
                    continue;
                }

                var card = new Card(rank, suit);
                if (this.cardsInPlayers.Any(c => c.CompareTo(card) == 0))
                {
                    Console.WriteLine("Card is not in the deck.");
                    i--;
                    continue;
                }

                this.cardsInPlayers.Add(card);
                this.MaxCardChecker(card, player);
            }
        }

        private void MaxCardChecker(Card card, string player)
        {
            if (this.winningCard == null)
            {
                this.winningCard = card;
                this.winner = player;
                return;
            }

            if (card.CompareTo(this.winningCard) > 0)
            {
                this.winningCard = card;
                this.winner = player;
            }
        }
    }
}
