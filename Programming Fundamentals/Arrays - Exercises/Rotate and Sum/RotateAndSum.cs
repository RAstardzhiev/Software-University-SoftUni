namespace Rotate_and_Sum
{
    using System;

    public class RotateAndSum
    {
        public static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int[] nums = new int[input.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                if (input.Length > 0)
                {
                    nums[i] = int.Parse(input[i]);
                }
            }

            int k = int.Parse(Console.ReadLine());
            int[] sums = new int[nums.Length];

            for (int i = 0; i < k; i++)
            {
                int temp = nums[0];
                nums[0] = nums[nums.Length - 1];
                for (int m = 1; m < nums.Length; m++)
                {
                    int internalTemp = nums[m];
                    nums[m] = temp;
                    temp = internalTemp;
                }

                for (int j = 0; j < sums.Length; j++)
                {
                    sums[j] += nums[j];
                }
            }

            Console.WriteLine(string.Join(" ", sums));
        }
    }
}
