namespace Condense_Array_to_Number
{
    using System;

    public class Condense_Array_to_Number
    {
        public static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine().Split();
            int[] nums = new int[numbers.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = int.Parse(numbers[i]);
            }

            if (nums.Length == 1)
            {
                Console.WriteLine($"{nums[0]} is already condensed to number");
            }
            else
            {
                while (true)
                {
                    int[] sums = new int[nums.Length - 1];
                    for (int i = 0; i < nums.Length - 1; i++)
                    {
                        sums[i] = nums[i] + nums[i + 1];
                    }

                    nums = sums;

                    if (nums.Length == 1)
                    {
                        Console.WriteLine(nums[0]);
                        break;
                    }
                }
            }
        }
    }
}
