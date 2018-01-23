namespace _06.SequenceN_M
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var start = input[0];
            var end = input[1];
            PrintShortestSequence(start, end);
        }

        private static void PrintShortestSequence(int start, int end)
        {
            if (end < start)
            {
                return;
            }

            var queue = new Queue<Item<int>>();
            queue.Enqueue(new Item<int>(start, null));

            while (true)
            {
                var currentItem = queue.Dequeue();
                if (currentItem.Value == end)
                {
                    PrintSteps(currentItem);
                    break;
                }
                else if (currentItem.Value > end)
                {
                    continue;
                }

                queue.Enqueue(new Item<int>(currentItem.Value + 1, currentItem));
                queue.Enqueue(new Item<int>(currentItem.Value + 2, currentItem));
                queue.Enqueue(new Item<int>(currentItem.Value * 2, currentItem));
            }
        }

        private static void PrintSteps(Item<int> currentItem)
        {
            var stack = new Stack<int>();

            while (currentItem != null)
            {
                stack.Push(currentItem.Value);
                currentItem = currentItem.PreviousItem;
            }

            Console.WriteLine(string.Join(" -> ", stack));
        }
    }
}
