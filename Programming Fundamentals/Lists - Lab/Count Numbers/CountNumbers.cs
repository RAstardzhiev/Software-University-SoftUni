namespace Count_Numbers
{
    using System;
    using System.Collections.Generic;

    public class CountNumbers
    {
        public static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            List<int> nums = new List<int>();
            foreach (var s in input)
            {
                if (s.Length > 0)
                {
                    nums.Add(int.Parse(s));
                }
            }

            nums.Sort();

            int count = 1;
            for (int i = 1; i < nums.Count; i++)
            {
                if (nums[i] == nums[i - 1])
                {
                    count++;
                }
                else
                {
                    Console.WriteLine($"{nums[i - 1]} -> {count}");
                    count = 1;
                }
            }

            Console.WriteLine($"{nums[nums.Count - 1]} -> {count}");
        }
    }
}
