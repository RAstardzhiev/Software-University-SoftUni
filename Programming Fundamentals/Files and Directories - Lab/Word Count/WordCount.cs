namespace Word_Count
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class WordCount
    {
        public static void Main(string[] args)
        {
            string[] keys = File.ReadAllText("Src/words.txt")
                .ToLower()
                .Split(' ');

            string[] text = File.ReadAllText("Src/text.txt")
                .ToLower()
                .Split(new char[] { '\n', '\r', ' ', '.', ',', '!', '?', '-' }, StringSplitOptions.RemoveEmptyEntries);

            File.WriteAllLines("Src/Keys Count.txt", KeysCount(keys, text).Select(x => $"{x.Key} - {x.Value}"));
        }

        private static Dictionary<string, int> KeysCount(string[] keys, string[] text)
        {
            Dictionary<string, int> keyCount = new Dictionary<string, int>();
            foreach (string key in keys)
            {
                keyCount[key] = 0;
            }

            foreach (string word in text)
            {
                if (keyCount.ContainsKey(word))
                {
                    keyCount[word]++;
                }
            }

            return keyCount
                .OrderByDescending(x => x.Value)
                .ToDictionary(x => x.Key, y => y.Value);
        }
    }
}
