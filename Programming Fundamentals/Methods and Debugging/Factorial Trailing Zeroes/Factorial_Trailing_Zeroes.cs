namespace Factorial_Trailing_Zeroes
{
    using System;
    using System.Numerics;

    public class Factorial_Trailing_Zeroes
    {
        public static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(TrailingZeroesInFactorial(number));
        }

        private static int TrailingZeroesInFactorial(int number)
        {
            string stringFactorial = string.Empty + Factorial(number);
            int zeroesCount = 0;
            for (int i = stringFactorial.Length - 1; i >= 0; i--)
            {
                if (stringFactorial[i] == '0')
                {
                    zeroesCount++;
                }
                else
                {
                    break;
                }
            }

            return zeroesCount;
        }

        private static BigInteger Factorial(int number)
        {
            if (number == 0)
            {
                return 1;
            }

            BigInteger factorial = number;
            for (int i = number - 1; i > 0; i--)
            {
                factorial = BigInteger.Multiply(factorial, i);
            }

            return factorial;
        }
    }
}
