namespace Rounding_Numbers
{
    using System;

    public class Rounding_Numbers
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] stringNums = input.Split();
            double[] numbers = new double[stringNums.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = double.Parse(stringNums[i]);
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("{0} => {1}", numbers[i], Math.Round(numbers[i], MidpointRounding.AwayFromZero));
            }
        }
    }
}
