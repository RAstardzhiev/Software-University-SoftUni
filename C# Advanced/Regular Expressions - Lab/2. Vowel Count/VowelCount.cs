namespace _2.Vowel_Count
{
    using System;
    using System.Text.RegularExpressions;

    public class VowelCount
    {
        public const string pattern = "[aeiouy]";

        public static void Main()
        {
            var text = Console.ReadLine();
            var vowels = Regex.Matches(text, pattern, RegexOptions.IgnoreCase).Count;
            Console.WriteLine($"Vowels: {vowels}");
        }
    }
}
