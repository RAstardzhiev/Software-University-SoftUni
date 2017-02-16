namespace Sum_big_numbers
{
    using System;
    using System.Linq;
    using System.Text;

    public class SumBigNumbers
    {
        public static void Main(string[] args)
        {
            /*
             * You are given two lines - each can be a really big number (0 to 10^50). You must display the sum of these numbers. 
             * Note: do not use the BigInteger or BigDecimal classes for solving this problem.
             */
            string firstNumber = Console.ReadLine().TrimStart('0');
            string secondNumber = Console.ReadLine().TrimStart('0');

            if (firstNumber.Contains('.') || secondNumber.Contains('.'))
            {
                Console.WriteLine(SumDoubles(firstNumber, secondNumber));
            }
            else
            {
                Console.WriteLine(SumIntegers(firstNumber, secondNumber));
            }
        }

        private static string SumDoubles(string firstNumber, string secondNumber)
        {
            if (!firstNumber.Contains('.'))
            {
                string afterDecimalPoint = secondNumber.Substring(secondNumber.IndexOf('.'));
                return SumIntegers(firstNumber, secondNumber.Substring(0, secondNumber.Length - afterDecimalPoint.Length)) + afterDecimalPoint;
            }
            else if (!secondNumber.Contains('.'))
            {
                string afterDecimalPoint = firstNumber.Substring(firstNumber.IndexOf('.'));
                return SumIntegers(firstNumber.Substring(0, firstNumber.Length - afterDecimalPoint.Length), secondNumber) + afterDecimalPoint;
            }
            else
            {
                string firstDoubleParrt = firstNumber.Substring(firstNumber.IndexOf('.') + 1);
                string secondDoublePart = secondNumber.Substring(secondNumber.IndexOf('.') + 1);

                string sumAfterDecimalPoint = $".{SumIntegers(firstDoubleParrt, secondDoublePart)}";
                string sumOfIntegerParts = SumIntegers(firstNumber.Substring(0, firstNumber.Length - firstDoubleParrt.Length - 1), secondNumber.Substring(0, secondNumber.Length - secondDoublePart.Length - 1));

                return string.Concat(sumOfIntegerParts, sumAfterDecimalPoint);
            }
        }

        private static string SumIntegers(string firstNumber, string secondNumber)
        {
            if (firstNumber.Length < secondNumber.Length)
            {
                return SumIntegers(secondNumber, firstNumber);
            }

            StringBuilder result = new StringBuilder(firstNumber.Length + 1);
            byte valueOnMind = 0;

            for (int i = 0; i < secondNumber.Length; i++)
            {
                byte currentCalculation = (byte)((firstNumber[firstNumber.Length - 1 - i] - '0') + (secondNumber[secondNumber.Length - 1 - i] - '0'));
                byte toAdd = (byte)(currentCalculation % 10 + valueOnMind);
                result.Insert(0, toAdd % 10);
                valueOnMind = (byte)(currentCalculation / 10);
                if (toAdd > 9)
                {
                    valueOnMind++;
                }
            }

            byte lengthDifference = (byte)(firstNumber.Length - secondNumber.Length);
            for (int i = lengthDifference - 1; i >= 0; i--)
            {
                byte currentCalculation = (byte)((firstNumber[i] - '0') + valueOnMind);
                result.Insert(0, currentCalculation % 10);
                valueOnMind = (byte)(currentCalculation / 10);
            }

            if (valueOnMind > 0)
            {
                result.Insert(0, valueOnMind);
            }

            return result.ToString();
        }
    }
}
