namespace _13.Magic_exchangeable_words
{
    using System;
    using System.Linq;

    public class MagicExchangeableWords
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split();
            var firstChars = input[0].ToCharArray().Distinct().ToArray();
            var secondChars = input[1].ToCharArray().Distinct().ToArray();
            Console.WriteLine(firstChars.Length == secondChars.Length ? "true" : "false");
        }
    }
}
