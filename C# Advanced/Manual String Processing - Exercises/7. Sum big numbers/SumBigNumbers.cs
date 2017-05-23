namespace _7.Sum_big_numbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class SumBigNumbers
    {
        public static void Main()
        {
            Stack<char> firstNumber = FilStack();
            Stack<char> secondNumber = FilStack();
            Console.WriteLine(SumTwoNumbers(firstNumber, secondNumber).TrimStart('0'));
        }

        private static string SumTwoNumbers(Stack<char> firstNumber, Stack<char> secondNumber)
        {
            // Sum equal lengths
            if (firstNumber == null || firstNumber.Count == 0)
            {
                return string.Join(string.Empty, secondNumber);
            }

            if (secondNumber == null || secondNumber.Count == 0)
            {
                return string.Join(string.Empty, firstNumber);
            }

            StringBuilder result = new StringBuilder();
            int minLength = Math.Min(firstNumber.Count, secondNumber.Count);
            var carrier = 0;

            for (int i = 0; i < minLength; i++)
            {
                carrier = SumChars(result, firstNumber, secondNumber, carrier);
            }

            // Add the digits from the greater length
            if (firstNumber.Count > 0)
            {
                AddTheRestChars(firstNumber, result, carrier);
            }

            if (secondNumber.Count > 0)
            {
                AddTheRestChars(secondNumber, result, carrier);
            }

            return result.ToString();
        }

        private static void AddTheRestChars(Stack<char> stack, StringBuilder result, int carrier)
        {
            while (stack.Count > 0)
            {
                int newValue = carrier + (stack.Pop() - '0');
                result.Insert(0, newValue % 10);
                carrier = newValue / 10;
            }

            // Check for carrier
            if (carrier > 0)
            {
                int newValue = (result[0] - '0') + carrier;
                result.Insert(0, newValue);
            }
        }

        private static int SumChars(StringBuilder result, Stack<char> firstNumber, Stack<char> secondNumber, int carrier)
        {
            int sum = (firstNumber.Pop() - '0') + (secondNumber.Pop() - '0') + carrier;
            result.Insert(0, sum % 10);

            if (sum > 9)
            {
                return sum / 10;
            }

            return 0;
        }

        private static Stack<char> FilStack()
        {
            Stack<char> stack = new Stack<char>();
            Console.ReadLine().Trim(new char[] { ' ', '\t', '\n', '\r' }).ToList().ForEach(ch => stack.Push(ch));
            return stack;
        }
    }
}
