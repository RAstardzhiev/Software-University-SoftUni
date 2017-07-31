namespace _03.Card_Power.Controllers
{
    using System;

    public class CardCompareTo
    {
        public void Run()
        {
            var firstCard = CardPower.GetCardFromConsole();
            var secondCard = CardPower.GetCardFromConsole();

            Console.WriteLine((firstCard.CompareTo(secondCard) > 0)
                ? firstCard
                : secondCard);
        }
    }
}
