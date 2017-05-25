namespace _11.Palindromes
{
    using System;
    using System.Collections.Generic;

    public class Palindromes
    {
        public static void Main()
        {
            var text = Console.ReadLine().Split(new char[] { ' ', '.', ',', '?', '!' }, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine($"[{string.Join(", ", ExtractPalindromes(text))}]");
        }

        private static SortedSet<string> ExtractPalindromes(string[] text)
        {
            var palindromes = new SortedSet<string>();

            foreach (var word in text)
            {
                var isPalindrome = true;

                for (int i = 0; i <= word.Length / 2; i++)
                {
                    if (word[i] != word[word.Length - 1 - i])
                    {
                        isPalindrome = false;
                        break;
                    }
                }

                if (isPalindrome)
                {
                    palindromes.Add(word);
                }
            }

            return palindromes;
        }
    }
}
