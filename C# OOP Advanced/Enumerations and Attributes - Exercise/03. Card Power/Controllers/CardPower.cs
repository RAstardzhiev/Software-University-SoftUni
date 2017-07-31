namespace _03.Card_Power.Controllers
{
    using System;
    using Enums;
    using Models;

    public class CardPower
    {
        public void Run()
        {
            var card = GetCardFromConsole();
            Console.WriteLine(card);
        }

        public static Card GetCardFromConsole()
        {
            var cardPower = Console.ReadLine();
            var cardSuit = Console.ReadLine();

            var power = (Rank)Enum.Parse(typeof(Rank), cardPower);
            var suit = (Suit)Enum.Parse(typeof(Suit), cardSuit);

            return new Card(power, suit);
        }
    }
}
