namespace Extract_sentences_by_keyword
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SentenceByKeyword
    {
        public static void Main(string[] args)
        {
            string key = Console.ReadLine();
            List<string> sentences = Console.ReadLine()
                .Split(".!?".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            Console.WriteLine(string.Join(Environment.NewLine, ExtractKeySentences(sentences, key)));
        }

        private static List<string> ExtractKeySentences(List<string> sentences, string key)
        {
            List<string> result = new List<string>();
            for (int i = 0; i < sentences.Count; i++)
            {
                if (ContainsKey(sentences[i], key))
                {
                    result.Add(sentences[i]);
                }
            }

            return result;
        }

        private static bool ContainsKey(string sentence, string key)
        {
            string[] words = sentence
                .Split(" ,\"\'\\/<>@#$%^&*()+=|".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            foreach (string word in words)
            {
                if (word.Equals(key))
                {
                    return true;
                }
            }

            return false;
        }
    }
}