namespace _2.SimpleCalculator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SimpleCalculator
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split("\t\n\r ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).Reverse().ToArray();
            Stack<int> numbers = new Stack<int>();
            Stack<string> operators = new Stack<string>();

            foreach (var str in input)
            {
                if (str == "+" || str == "-")
                {
                    operators.Push(str);
                    continue;
                }

                numbers.Push(int.Parse(str));
            }

            if (numbers.Count == 0)
            {
                return;
            }

            PrintResult(numbers, operators);
        }

        private static void PrintResult(Stack<int> numbers, Stack<string> operators)
        {
            int result = numbers.Pop();

            while (numbers.Count > 0)
            {
                result = (CalculateNext(numbers, operators, result));
            }

            Console.WriteLine(result);
        }

        private static int CalculateNext(Stack<int> numbers, Stack<string> operators, int result)
        {
            switch (operators.Pop())
            {
                case "+":
                    return result + numbers.Pop();
                case "-":
                    return result - numbers.Pop();
                default:
                    break;
            }

            return result;
        }
    }
}
