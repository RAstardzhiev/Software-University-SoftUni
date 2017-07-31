namespace _03.Card_Power.Controllers
{
    using System;
    using Enums;

    public class CustomEnumAttribute
    {
        public void Run()
        {
            var targetEnum = Console.ReadLine();

            var enumType = targetEnum == "Rank"
                ? typeof(Rank)
                : typeof(Suit);

            var attributes = enumType.GetCustomAttributes(false);
            Console.WriteLine(string.Join(Environment.NewLine, attributes));
        }
    }
}
