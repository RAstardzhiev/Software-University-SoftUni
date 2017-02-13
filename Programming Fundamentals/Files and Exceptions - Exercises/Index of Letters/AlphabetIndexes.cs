namespace Index_of_Letters
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class AlphabetIndexes
    {
        public static void Main(string[] args)
        {
            string[] text = File.ReadAllLines("../../InputOutput/Input.txt");

            foreach (string line in text)
            {
                WriteIndexes(line
                    .ToCharArray()
                    .Where(x => char.IsLetter(x))
                    .Distinct()
                    .ToArray());
            }
        }

        private static void WriteIndexes(char[] letters)
        {
            Dictionary<char, int> alphabet = AlphabetDict();
            string result = "Letter -> Place in alphabet" + 
                Environment.NewLine + 
                "Text: " + 
                new string(letters) + 
                Environment.NewLine;

            for (int i = 0; i < letters.Length; i++)
            {
                result += $"{letters[i]} -> {alphabet[letters[i]]}{Environment.NewLine}";
            }

            result += Environment.NewLine;

            File.AppendAllText("../../InputOutput/Output.txt", result);
        }

        private static Dictionary<char, int> AlphabetDict()
        {
            Dictionary<char, int> alphabet = new Dictionary<char, int>(26);

            for (char i = 'a'; i <= 'z'; i++)
            {
                alphabet[i] = i - 'a' + 1;
            }

            return alphabet;
        }
    }
}
