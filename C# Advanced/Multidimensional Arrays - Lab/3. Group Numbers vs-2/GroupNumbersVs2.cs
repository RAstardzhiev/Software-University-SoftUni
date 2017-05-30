namespace _3.Group_Numbers_vs_2
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class GroupNumbersVs2
    {
        public static void Main()
        {
            var numbers = ReadInput();
            Console.WriteLine(string.Join(Environment.NewLine, numbers.Values.Select(n => string.Join(" ", n))));
        }

        private static SortedDictionary<int, Queue<int>> ReadInput()
        {
            var numbers = new SortedDictionary<int, Queue<int>>()
            {
                { 0, new Queue<int>() },
                { 1, new Queue<int>() },
                { 2, new Queue<int>() }
            };

            var input = Console.ReadLine()
                .Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse);

            foreach (var num in input)
            {
                numbers[Math.Abs(num) % 3].Enqueue(num);
            }

            return numbers;
        }
    }
}
