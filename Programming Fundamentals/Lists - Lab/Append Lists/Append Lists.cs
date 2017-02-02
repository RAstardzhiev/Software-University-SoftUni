namespace Append_Lists
{
    using System;
    using System.Collections.Generic;

    public class Append_Lists
    {
        public static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split('|');

            List<int> output = new List<int>();

            for (int i = input.Length - 1; i >= 0; i--)
            {
                string[] temp = input[i].Split(' ');
                foreach (string num in temp)
                {
                    if (num.Length > 0)
                    {
                        output.Add(int.Parse(num));
                    }
                }
            }

            Console.WriteLine(string.Join(" ", output));
        }
    }
}
