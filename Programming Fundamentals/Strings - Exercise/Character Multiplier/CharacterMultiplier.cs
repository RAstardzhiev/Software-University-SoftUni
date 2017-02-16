namespace Character_Multiplier
{
    using System;

    public class CharacterMultiplier
    {
        public static void Main(string[] args)
        {
            // Create a method that takes two strings as arguments and returns 
            // the sum of their character codes multiplied (multiply str1.charAt (0) with str2.charAt (0) 
            // and add to the total sum). Then continue with the next two characters. If one of the strings is longer 
            // than the other, add the remaining character codes to the total sum without multiplication.
            string[] input = Console.ReadLine().Split(' ');
            Console.WriteLine(SumMultipliedChars(input[0], input[1]));
        }

        private static int SumMultipliedChars(string firstString, string secondString)
        {
            int sum = 0;
            int shorterLength = Math.Min(firstString.Length, secondString.Length);

            for (int i = 0; i < shorterLength; i++)
            {
                sum += (int)firstString[i] * (int)secondString[i];
            }

            sum = SumTheRest(sum, shorterLength, (firstString.Length > secondString.Length) ? firstString : secondString);
            return sum;
        }

        private static int SumTheRest(int sum, int shorterLength, string str)
        {
            for (int i = shorterLength; i < str.Length; i++)
            {
                sum += (int)str[i];
            }

            return sum;
        }
    }
}
