namespace Index_of_Letters
{
    using System;

    public class IndexOfLetters
    {
        public static void Main(string[] args)
        {
            char[] letters = new char[26];
            for (int i = 97; i < letters.Length + 97; i++)
            {
                letters[i - 97] = (char)i;
            }

            string input = Console.ReadLine();
            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < letters.Length; j++)
                {
                    if (letters[j] == input[i])
                    {
                        Console.WriteLine($"{input[i]} -> {j}");
                    }
                }
            }
        }
    }
}
