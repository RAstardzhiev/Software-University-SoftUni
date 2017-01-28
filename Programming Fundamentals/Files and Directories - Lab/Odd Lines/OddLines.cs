namespace Odd_Lines
{
    using System;
    using System.IO;

    public class OddLines
    {
        public static void Main(string[] args)
        {
            string[] input = File.ReadAllLines("input.txt");
            PrintOddLines(input);
        }

        private static void PrintOddLines(string[] input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(input[i]);
                }
            }
        }
    }
}
