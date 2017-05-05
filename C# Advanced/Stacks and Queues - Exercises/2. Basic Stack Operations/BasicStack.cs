namespace _2.Basic_Stack_Operations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class BasicStack
    {
        public static void Main()
        {
            int[] commands = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var stack = new Stack<int>();

            for (int i = 0; i < commands[0] && i < numbers.Length; i++)
            {
                stack.Push(numbers[i]);
            }

            for (int i = 0; i < commands[1] && stack.Count > 0; i++)
            {
                stack.Pop();
            }

            Console.WriteLine(stack.Count == 0 ? "0" : stack.Contains(commands[2]) ? "true" : $"{stack.Min()}");
        }
    }
}
