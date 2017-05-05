namespace _4.Basic_Queue_Operations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class BasicQueue
    {
        public static void Main()
        {
            int[] commands = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var queue = new Queue<int>();

            if (commands.Length > 1 && commands[0] > commands[1])
            {            
                Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Skip(commands[1])
                .Select(int.Parse)
                .ToList()
                .ForEach(n => queue.Enqueue(n));
            }

            if (commands.Length > 2)
            {
                Console.WriteLine(queue.Contains(commands[2]) ? "true" : queue.Count == 0 ? "0" : $"{queue.Min()}");
            }
        }
    }
}
