namespace Match_full_name
{
    using System;
    using System.Text.RegularExpressions;

    public class NameFinder
    {
        public static void Main(string[] args)
        {
            string text = Console.ReadLine();
            Regex regex = new Regex(@"\b[A-Z][a-z]+\s[A-Z][a-z]+\b");

            foreach (Match match in regex.Matches(text))
            {
                Console.WriteLine(match.Value);
            }
        }
    }
}
