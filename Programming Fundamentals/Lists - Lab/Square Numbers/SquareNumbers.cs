namespace Square_Numbers
{
    using System;
    using System.Collections.Generic;

    public class SquareNumbers
    {
        public static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            List<int> squares = new List<int>();

            foreach (string num in input)
            {
                if (num.Length > 0 && Math.Sqrt(double.Parse(num)) == (int)Math.Sqrt(double.Parse(num)))
                {
                    squares.Add(int.Parse(num));
                }
            }

            squares.Sort((a, b) => b.CompareTo(a));

            Console.WriteLine(string.Join(" ", squares));
        }
    }
}