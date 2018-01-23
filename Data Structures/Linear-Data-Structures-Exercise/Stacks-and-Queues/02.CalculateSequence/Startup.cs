namespace _02.CalculateSequence
{
    using System;
    using System.Collections.Generic;

    public class Startup
    {
        public const int NumbersToPrint = 50;

        public static void Main()
        {
            var result = new int[NumbersToPrint];
            FillSequence(result);
            Console.WriteLine(string.Join(", ", result));
        }

        private static void FillSequence(int[] result)
        {
            var startNumber = int.Parse(Console.ReadLine());
            result[0] = startNumber;

            var queue = new Queue<int>();
            queue.Enqueue(startNumber);

            for (int i = 1; i < result.Length; i++)
            {
                var currentNumber = queue.Peek() + 1;
                var isNumberAdded = TryAddNumber(result, i, currentNumber);
                if (!isNumberAdded)
                {
                    return;
                }

                queue.Enqueue(currentNumber);
                i++;

                currentNumber = 2 * queue.Peek() + 1;
                isNumberAdded = TryAddNumber(result, i, currentNumber);
                if (!isNumberAdded)
                {
                    return;
                }

                queue.Enqueue(currentNumber);
                i++;

                currentNumber = queue.Dequeue() + 2;
                isNumberAdded = TryAddNumber(result, i, currentNumber);
                if (!isNumberAdded)
                {
                    break;
                }

                queue.Enqueue(currentNumber);
            }
        }

        private static bool TryAddNumber(int[] collection, int index, int value)
        {
            if (index >= NumbersToPrint)
            {
                return false;
            }

            collection[index] = value;
            return true;
        }
    }
}
