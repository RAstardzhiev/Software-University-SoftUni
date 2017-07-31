namespace _03.Card_Power
{
    using Controllers;

    public class StartUp
    {
        public static void Main()
        {
            new CardPower().Run(); // Problem 3. Card Power and Problem 4. Card ToString()
            new CardCompareTo().Run(); // Problem 5. Card CompareTo()
            new CustomEnumAttribute().Run(); // Problem 6. Custom Enum Attribute
            new DeckOfCards().Run(); // Problem 7. Deck of Cards
            new CardGame().Run(); // Problem 8. Card Game
        }
    }
}
