namespace Hands_of_Cards
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class HandsOfCards
    {
        public static void Main(string[] args)
        {
            Dictionary<string, string[]> cardsGame = new Dictionary<string, string[]>();
            while (true)
            {
                string comand = Console.ReadLine();

                if (comand.Equals("JOKER"))
                {
                    break;
                }

                string player = comand.Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries)[0];
                comand = comand.Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries)[1];
                string[] cards = comand
                    .Split(' ', ',')
                    .Where(x => !x.Equals(string.Empty))
                    .ToArray();

                if (cardsGame.ContainsKey(player))
                {
                    cardsGame[player] = cardsGame[player]
                        .Concat(cards)
                        .Distinct()
                        .ToArray();
                }
                else
                {
                    cardsGame[player] = cards
                        .Distinct()
                        .ToArray();
                }
            }

            foreach (KeyValuePair<string, string[]> player in cardsGame)
            {
                Console.WriteLine($"{player.Key}: {GetScore(player.Value)}");
            }
        }

        public static int GetScore(string[] cards)
        {
            // Each card has a value that is calculated by the power multiplied by the type. 
            // Powers 2 to 10 have the same value and J to A are 11 to 14. 
            int score = 0;
            foreach (string card in cards)
            {
                score += GetPower(card) * GetMultiplier(card);
            }

            return score;
        }

        public static int GetPower(string card)
        {
            // J = 11, Q = 12, K = 13, A = 14
            switch (card[0])
            {
                case 'J': return 11;
                case 'Q': return 12;
                case 'K': return 13;
                case 'A': return 14;
                default: return int.Parse(card.Substring(0, card.Length - 1));
            }
        }

        public static int GetMultiplier(string card)
        {
            // Types are mapped to multipliers the following way (S -> 4, H-> 3, D -> 2, C -> 1).
            switch (card[card.Length - 1])
            {
                case 'S': return 4;
                case 'H': return 3;
                case 'D': return 2;
                case 'C': return 1;
                default:
                    return 0;
            }
        }
    }
}
