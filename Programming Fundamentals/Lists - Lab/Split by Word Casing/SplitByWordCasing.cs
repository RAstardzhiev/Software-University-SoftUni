namespace Split_by_Word_Casing
{
    using System;
    using System.Collections.Generic;

    public class SplitByWordCasing
    {
        public static void Main(string[] args)
        {
            // Use the following separators between the words: , ; : . ! ( ) " ' \ / [ ] space
            string[] input = Console.ReadLine().Split(' ', ',', ';', ':', '.', '!', '(', ')', '"', '\'', '\\', '/', '[', ']');

            List<string> lowerCase = new List<string>();
            List<string> upperCase = new List<string>();
            List<string> mixedCase = new List<string>();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i].Length > 0)
                {
                    int lowerCount = 0, upperCount = 0;
                    for (int k = 0; k < input[i].Length; k++)
                    {
                        if (input[i][k] >= 'a' && input[i][k] <= 'z')
                        {
                            lowerCount++;
                        }
                        else if (input[i][k] >= 'A' && input[i][k] <= 'Z')
                        {
                            upperCount++;
                        }
                    }

                    if (lowerCount == input[i].Length)
                    {
                        lowerCase.Add(input[i]);
                    }
                    else if (upperCount == input[i].Length)
                    {
                        upperCase.Add(input[i]);
                    }
                    else
                    {
                        mixedCase.Add(input[i]);
                    }
                }
            }

            Console.WriteLine("Lower-case: {0}\nMixed-case: {1}\nUpper-case: {2}", string.Join(", ", lowerCase), string.Join(", ", mixedCase), string.Join(", ", upperCase));
        }
    }
}
