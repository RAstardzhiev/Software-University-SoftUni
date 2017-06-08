namespace _1.Match_Count
{
    using System;
    using System.Text.RegularExpressions;

    public class MatchCount
    {
        public static void Main()
        {
            var key = Console.ReadLine();
            var text = Console.ReadLine();

            var matchesCount = Regex.Matches(text, key).Count;
            Console.WriteLine(matchesCount);
        }
    }
}
