namespace Max_Sequence_of_Increasing_Elements
{
    using System;

    public class MaxSequenceIncreasingElements
    {
        public static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            long[] nums = new long[input.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = long.Parse(input[i]);
            }

            int startIndex = 0, endIndex = 1, currentSequence = 1, maxSequence = 1;

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] > nums[i - 1])
                {
                    currentSequence++;
                    if (currentSequence > maxSequence)
                    {
                        startIndex = i - currentSequence + 1;
                        endIndex = i + 1;
                        maxSequence = currentSequence;
                    }
                }
                else
                {
                    currentSequence = 1;
                }
            }

            for (int i = startIndex; i < endIndex; i++)
            {
                Console.Write($"{nums[i]} ");
            }
        }
    }
}
