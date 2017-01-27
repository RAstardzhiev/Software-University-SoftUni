namespace Most_Frequent_Number
{
    using System;

    public class MostFrequentNumber
    {
        public static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int[] nums = new int[input.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = int.Parse(input[i]);
            }

            int maxFrequent = 1, maxFrequentIndex = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                int currentMax = 0, key = nums[i];
                for (int j = 0; j < nums.Length; j++)
                {
                    if (key == nums[j])
                    {
                        currentMax++;
                    }
                }

                if (currentMax > maxFrequent)
                {
                    maxFrequent = currentMax;
                    maxFrequentIndex = i;
                }
            }

            Console.WriteLine(nums[maxFrequentIndex]);
        }
    }
}
