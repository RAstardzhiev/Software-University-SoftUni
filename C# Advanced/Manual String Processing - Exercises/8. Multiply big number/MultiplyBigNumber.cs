namespace _8.Multiply_big_number
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class MultiplyBigNumber
    {
        public static void Main()
        {
            char[] firstNumber = Console.ReadLine().Trim(new char[] { ' ', '\n', '\r', '\t' }).TrimStart('0').ToCharArray();
            char[] secondNumber = Console.ReadLine().Trim(new char[] { ' ', '\n', '\r', '\t' }).TrimStart('0').ToCharArray();

            string result = Multiply(firstNumber, secondNumber);
            Console.WriteLine(result);
        }

        private static string Multiply(char[] firstNumber, char[] secondNumber)
        {
            if (firstNumber.Length < 1 || firstNumber == null)
            {
                return "0";
            }

            if (secondNumber.Length < 1 || secondNumber == null)
            {
                return "0";
            }

            bool isFirstNumNegative = firstNumber[0] == '-';
            bool isSecondNumNegative = secondNumber[0] == '-';
            bool isResultNegative = isFirstNumNegative ^ isSecondNumNegative;

            if (isFirstNumNegative)
            {
                firstNumber = firstNumber.Skip(1).ToArray();
            }

            if (isSecondNumNegative)
            {
                secondNumber = secondNumber.Skip(1).ToArray();
            }

            // Start the calculations
            List<Stack<char>> multiplicationRows = HandMultiplication(firstNumber, secondNumber);
            string result = SumRows(multiplicationRows);
            return isResultNegative ? $"-{result}" : result;
        }

        private static string SumRows(List<Stack<char>> multiplicationRows)
        {
            StringBuilder sb = new StringBuilder();
            int carried = 0;

            while (multiplicationRows.Count > 0)
            {
                int sum = 0;

                for (int i = 0; i < multiplicationRows.Count; i++)
                {
                    sum += multiplicationRows[i].Pop() - '0';

                    if (multiplicationRows[i].Count < 1)
                    {
                        multiplicationRows.RemoveAt(i);
                    }
                }

                sum += carried;
                sb.Insert(0, sum % 10);
                carried = sum / 10;
            }

            if (carried > 0)
            {
                sb.Insert(0, carried);
            }

            return sb.ToString();
        }

        private static List<Stack<char>> HandMultiplication(char[] longerNumber, char[] shorterNumber)
        {
            if (shorterNumber.Length > longerNumber.Length)
            {
                return HandMultiplication(shorterNumber, longerNumber);
            }

            List<Stack<char>> multiplicationRows = new List<Stack<char>>();
            StringBuilder sb = new StringBuilder();
            int carried = 0;

            for (int sNumIndex = shorterNumber.Length - 1; sNumIndex >= 0; sNumIndex--)
            {
                for (int lNumIndex = longerNumber.Length - 1; lNumIndex >= 0; lNumIndex--)
                {
                    int multiplied = (shorterNumber[sNumIndex] - '0') * (longerNumber[lNumIndex] - '0') + carried;
                    sb.Insert(0, multiplied % 10);
                    carried = multiplied / 10;
                }

                if (carried > 0)
                {
                    sb.Insert(0, carried);
                }

                Stack<char> currentRow = new Stack<char>();

                for (int i = 0; i < sb.Length; i++)
                {
                    currentRow.Push(sb[i]);
                }

                multiplicationRows.Add(currentRow);

                sb.Clear();
            }

            return multiplicationRows;
        }
    }
}
