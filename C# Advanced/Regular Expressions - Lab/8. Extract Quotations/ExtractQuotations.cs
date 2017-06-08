namespace _8.Extract_Quotations
{
    using System;
    using System.Text.RegularExpressions;

    public class ExtractQuotations
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var matches = Regex.Matches(input, @"(['|""])([\S\s]+?)\1");

            foreach (Match match in matches)
            {
                Console.WriteLine(match.Groups[2]);
            }
        }
    }
}
