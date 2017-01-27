namespace Equal_Sums
{
    using System;

    public class EqualSums
    {
        public static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int[] nums = new int[input.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = int.Parse(input[i]);
            }

            for (int i = 0; i < nums.Length; i++)
            {
                int rightSum = 0, leftsum = 0;
                for (int j = 0; j < i; j++)
                {
                    leftsum += nums[j];
                }

                for (int j = i + 1; j < nums.Length; j++)
                {
                    rightSum += nums[j];
                }

                if (leftsum == rightSum)
                {
                    Console.WriteLine(i);
                    return;
                }
            }

            Console.WriteLine("no");
        }
    }
}
