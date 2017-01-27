namespace Max_Sequence_of_Equal_Elements
{
    using System;

    public class MaxSequenceEqualElements
    {
        public static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int[] nums = new int[input.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = int.Parse(input[i]);
            }

            int startIndex = 0, endIndex = 1, countEquals = 1;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] == nums[i - 1])
                {
                    countEquals++;
                    if (countEquals > endIndex - startIndex)
                    {
                        startIndex = i - countEquals + 1;
                        endIndex = i + 1;
                    }
                }
                else
                {
                    countEquals = 1;
                }
            }

            for (int i = startIndex; i < endIndex; i++)
            {
                Console.Write("{0} ", nums[i]);
            }

            Console.WriteLine();
        }
    }
}
