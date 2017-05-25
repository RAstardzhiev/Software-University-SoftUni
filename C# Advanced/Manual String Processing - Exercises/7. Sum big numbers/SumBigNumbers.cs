namespace _7.Sum_big_numbers
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class SumBigNumbers
    {
        public static void Main()
        {
            Stack<char> firstNumber = FillStack();
            Stack<char> secondNumber = FillStack();
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
            var carried = 0;

            for (int i = 0; i < minLength; i++)
            {
                carried = SumChars(result, firstNumber, secondNumber, carried);
            }

            // Add the digits from the greater length
            if (firstNumber.Count > 0)
            {
                AddTheRestChars(firstNumber, result, carried);
            }

            if (secondNumber.Count > 0)
            {
                AddTheRestChars(secondNumber, result, carried);
            }

            return result.ToString();
        }

        private static void AddTheRestChars(Stack<char> stack, StringBuilder result, int carried)
        {
            while (stack.Count > 0)
            {
                int newValue = carried + (stack.Pop() - '0');
                result.Insert(0, newValue % 10);
                carried = newValue / 10;
            }

            // Check for carried
            if (carried > 0)
            {
                int newValue = (result[0] - '0') + carried;
                result.Insert(0, newValue);
            }
        }

        private static int SumChars(StringBuilder result, Stack<char> firstNumber, Stack<char> secondNumber, int carried)
        {
            int sum = (firstNumber.Pop() - '0') + (secondNumber.Pop() - '0') + carried;
            result.Insert(0, sum % 10);

            if (sum > 9)
            {
                return sum / 10;
            }

            return 0;
        }

        private static Stack<char> FillStack()
        {
            Stack<char> stack = new Stack<char>();
            char[] input = Console.ReadLine().Trim(new char[] { ' ', '\n', '\r', '\t' }).TrimStart('0').ToCharArray();

            foreach (var ch in input)
            {
                stack.Push(ch);
            }

            return stack;
        }
    }
}
