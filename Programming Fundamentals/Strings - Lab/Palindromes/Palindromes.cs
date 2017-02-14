namespace Palindromes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Palindromes
    {
        public static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new char[] { ' ', ',', '.', '?', '!' }, StringSplitOptions.RemoveEmptyEntries);
            List<string> stringPalindromes = StringPalindromes(input);
            stringPalindromes = stringPalindromes.Distinct().ToList();
            stringPalindromes.Sort();
            Console.WriteLine(string.Join(", ", stringPalindromes));
        }

        private static List<string> StringPalindromes(string[] input)
        {
            List<string> result = new List<string>();
            foreach (string word in input)
            {
                if (word.Equals(new string(word.ToCharArray().Reverse().ToArray())))
                {
                    result.Add(word);
                }
            }

            return result;
        }
    }
}
