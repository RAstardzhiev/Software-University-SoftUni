namespace _8.Hands_of_Cards
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class HandsOfCards
    {
        public static void Main()
        {
            Dictionary<string, int> gameResult = PlayTheGame();

            Console.WriteLine(string.Join(Environment.NewLine, gameResult.Select(p => $"{p.Key}: {p.Value}")));
        }

        private static Dictionary<string, int> PlayTheGame()
        {
            // Collect input data
            var players = new Dictionary<string, HashSet<string>>();
            var input = Console.ReadLine();

            while (input != "JOKER")
            {
                var separator = input.IndexOf(':');
                if (separator < 0)
                {
                    break;
                }

                var name = input.Substring(0, separator);
                if (!players.ContainsKey(name))
                {
                    players[name] = new HashSet<string>();
                }

                var cards = input
                    .Substring(separator + 1)
                    .Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

                foreach (var card in cards)
                {
                    players[name].Add(card);
                }

                input = Console.ReadLine();
            }

            // Calculate total values of each player
            var gameResult = new Dictionary<string, int>();
            foreach (var player in players)
            {
                gameResult[player.Key] = GetTotalValue(player.Value);
            }

            return gameResult;
        }

        private static int GetTotalValue(HashSet<string> hand)
        {
            var result = 0;

            foreach (var card in hand)
            {
                // Powers: 2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K, A
                var power = 0;
                switch (card.Substring(0, card.Length - 1))
                {
                    case "2":
                        power = 2;
                        break;
                    case "3":
                        power = 3;
                        break;
                    case "4":
                        power = 4;
                        break;
                    case "5":
                        power = 5;
                        break;
                    case "6":
                        power = 6;
                        break;
                    case "7":
                        power = 7;
                        break;
                    case "8":
                        power = 8;
                        break;
                    case "9":
                        power = 9;
                        break;
                    case "10":
                        power = 10;
                        break;
                    case "J":
                        power = 11;
                        break;
                    case "Q":
                        power = 12;
                        break;
                    case "K":
                        power = 13;
                        break;
                    case "A":
                        power = 14;
                        break;
                    default:
                        break;
                }

                // Suits: S, H, D, C
                var suit = 0;
                switch (card.Last())
                {
                    case 'S':
                        suit = 4;
                        break;
                    case 'H':
                        suit = 3;
                        break;
                    case 'D':
                        suit = 2;
                        break;
                    case 'C':
                        suit = 1;
                        break;
                    default:
                        break;
                }

                result += suit * power;
            }

            return result;
        }
    }
}
