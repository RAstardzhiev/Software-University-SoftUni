namespace Multiply_Evens_by_Odds
{
    using System;

    public class MultiplyEvensByOdds
    {
        public static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            int evenSum = EvenSum(number);
            int oddSum = OddSum(number);
            Console.WriteLine(evenSum * oddSum);
        }

        private static int OddSum(long number)
        {
            int sum = 0;
            while (number != 0)
            {
                if ((number % 10) % 2 != 0)
                {
                    sum += (int)(number % 10);
                }

                number /= 10;
            }

            return sum;
        }

        private static int EvenSum(long number)
        {
            int sum = 0;
            while (number != 0)
            {
                if ((number % 10) % 2 == 0)
                {
                    sum += (int)(number % 10);
                }

                number /= 10;
            }

            return sum;
        }
    }
}
