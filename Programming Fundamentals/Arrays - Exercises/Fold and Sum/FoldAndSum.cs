namespace Fold_and_Sum
{
    using System;

    public class FoldAndSum
    {
        public static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            for (int i = (input.Length / 4) - 1, j = input.Length / 4; i >= 0; i--, j++)
            {
                Console.Write("{0} ", int.Parse(input[i]) + int.Parse(input[j]));
            }

            for (int i = input.Length / 2, j = input.Length - 1; i < j; i++, j--)
            {
                Console.Write("{0} ", int.Parse(input[i]) + int.Parse(input[j]));
            }

            Console.WriteLine();
        }
    }
}
