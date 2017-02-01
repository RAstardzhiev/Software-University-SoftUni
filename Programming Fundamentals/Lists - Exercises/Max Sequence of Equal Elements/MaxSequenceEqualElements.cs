namespace Max_Sequence_of_Equal_Elements_12
{
    using System;
    using System.Collections.Generic;

    public class MaxSequenceEqualElements
    {
        public static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            List<int> nums = new List<int>();
            for (int i = 0; i < input.Length; i++)
            {
                nums.Add(int.Parse(input[i]));
            }

            int maxSequence = 1, currentSequence = 1, indexToStartPrinting = 0;
            for (int i = 1; i < nums.Count; i++)
            {
                if (nums[i] == nums[i - 1])
                {
                    currentSequence++;
                    if (currentSequence > maxSequence)
                    {
                        maxSequence = currentSequence;
                        indexToStartPrinting = i + 1 - maxSequence;
                    }
                }
                else
                {
                    currentSequence = 1;
                }
            }

            for (int i = indexToStartPrinting; i < indexToStartPrinting + maxSequence; i++)
            {
                Console.Write("{0} ", nums[i]);
            }
        }
    }
}
