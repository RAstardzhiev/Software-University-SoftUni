namespace _6.Sentence_Extractor
{
    using System;
    using System.Text.RegularExpressions;

    public class SentenceExtractor
    {
        public static void Main()
        {
            var key = Console.ReadLine();
            var text = Console.ReadLine();
            var matches = Regex.Matches(text, $@"[^.!?]+?\b{key}\b[^.!?]+?[!?.]", RegexOptions.IgnoreCase);

            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);
            }
        }
    }
}
