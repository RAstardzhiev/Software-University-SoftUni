namespace Bomb_Numbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class BombNumbers
    {
        public static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int[] bombAndPower = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            List<int> nums = new List<int>();
            for (int i = 0; i < input.Length; i++)
            {
                nums.Add(int.Parse(input[i]));
            }

            PrintRemainingSum(nums, bombAndPower[0], bombAndPower[1]);
        }

        public static void PrintRemainingSum(List<int> nums, int bomb, int power)
        {
            for (int i = 0; i < nums.Count; i++)
            {
                if (nums[i] == bomb)
                {
                    int dell = (i - power < 0) ? 0 : (i - power);
                    int j = 0;
                    while (dell < nums.Count && j < (2 * power) + 1)
                    {
                        nums.RemoveAt(dell);
                        j++;
                    }

                    i = 0;
                }
            }

            int sum = 0;
            for (int i = 0; i < nums.Count; i++)
            {
                sum += nums[i];
            }

            Console.WriteLine(sum);
        }
    }
}
