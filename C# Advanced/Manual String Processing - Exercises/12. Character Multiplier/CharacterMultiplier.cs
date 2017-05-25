namespace _12.Character_Multiplier
{
    using System;
    using System.Collections.Generic;

    public class CharacterMultiplier
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(' ');
            var firstWord = FillQueue(input[0]);
            var secondWord = FillQueue(input[1]);
            Console.WriteLine(MultiplyWords(firstWord, secondWord));
        }

        private static int MultiplyWords(Queue<char> longerWord, Queue<char> shorterWord)
        {
            if (longerWord.Count < shorterWord.Count)
            {
                return MultiplyWords(shorterWord, longerWord);
            }

            var sum = 0;

            while (shorterWord.Count > 0)
            {
                sum += longerWord.Dequeue() * shorterWord.Dequeue();
            }

            while (longerWord.Count > 0)
            {
                sum += longerWord.Dequeue();
            }

            return sum;
        }

        private static Queue<char> FillQueue(string word)
        {
            var queue = new Queue<char>(word.Length);

            for (int i = 0; i < word.Length; i++)
            {
                queue.Enqueue(word[i]);
            }

            return queue;
        }
    }
}
