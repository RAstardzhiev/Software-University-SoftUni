namespace List_Manipulator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ListManipulator
    {
        public static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToList();
            while (true)
            {
                string[] comand = Console.ReadLine().Split(' ');
                if (comand[0].Equals("print"))
                {
                    break;
                }

                switch (comand[0])
                {
                    case "addMany":
                        // addMany <index> <element 1> <element 2> … <element n> – adds a set of elements at the specified index
                        int[] toAdd = comand.Skip(2).Select(int.Parse).ToArray();
                        nums.InsertRange(int.Parse(comand[1]), toAdd);
                        break;
                    case "add":
                        // add < index > < element > – adds element at the specified index (elements right from this position inclusively are shifted to the right).
                        nums.Insert(int.Parse(comand[1]), int.Parse(comand[2]));
                        break;
                    case "contains":
                        // contains <element> – prints the index of the first occurrence of the specified element (if exists) in the array or -1 if the element is not found
                        Console.WriteLine(nums.IndexOf(int.Parse(comand[1])));
                        break;
                    case "remove":
                        // remove <index> – removes the element at the specified index
                        nums.RemoveAt(int.Parse(comand[1]));
                        break;
                    case "shift":
                        Shift(nums, int.Parse(comand[1]));
                        break;
                    case "sumPairs":
                        SumPairs(nums);
                        break;
                    default:
                        break;
                }
            }

            Console.WriteLine("[" + string.Join(", ", nums) + "]");
        }

        public static void SumPairs(List<int> nums)
        {
            // sumPairs – sums the elements in the array by pairs (first + second, third + fourth, …).
            // o For example, [1, 2, 4, 5, 6, 7, 8] -> [3, 9, 13, 8].
            for (int i = 1; i < nums.Count; i++)
            {
                nums[i - 1] += nums[i];
                nums.RemoveAt(i);
            }
        }

        public static void Shift(List<int> nums, int positions)
        {
            // shift <positions> – shifts every element of the array the number of positions to the left (with rotation).
            // o For example, [1, 2, 3, 4, 5] -> shift 2 -> [3, 4, 5, 1, 2]
            for (int i = 0; i < positions; i++)
            {
                int temp = nums[0];
                nums.RemoveAt(0);
                nums.Add(temp);
            }
        }
    }
}
