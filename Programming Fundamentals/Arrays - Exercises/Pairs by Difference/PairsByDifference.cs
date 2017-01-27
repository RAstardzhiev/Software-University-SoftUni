namespace Pairs_by_Difference
{
    using System;

    public class PairsByDifference
    {
        public static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int[] nums = new int[input.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = int.Parse(input[i]);
            }

            int difference = int.Parse(Console.ReadLine());

            int count = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                int key = nums[i];
                for (int j = 0; j < nums.Length; j++)
                {
                    if (key == nums[j] + difference)
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine(count);
        }
    }
}
