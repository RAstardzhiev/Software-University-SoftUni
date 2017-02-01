namespace Array_Manipulator
{
    using System;
    using System.Linq;

    public class ArrayManipulator
    {
        public static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToArray();
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
                        int[] toAdd = new int[comand.Length - 2];
                        for (int i = 0; i < toAdd.Length; i++)
                        {
                            toAdd[i] = int.Parse(comand[i + 2]);
                        }

                        nums = AddMany(nums, int.Parse(comand[1]), toAdd);
                        break;
                    case "add": nums = AddElement(nums, int.Parse(comand[1]), int.Parse(comand[2]));
                        break;
                    case "contains": PrintIndex(nums, int.Parse(comand[1]));
                        break;
                    case "remove": nums = RemoveIndex(nums, int.Parse(comand[1]));
                        break;
                    case "shift": nums = Shift(nums, int.Parse(comand[1]));
                        break;
                    case "sumPairs": nums = SumPairs(nums);
                        break;
                    default:
                        break;
                }
            }

            Console.WriteLine("[" + string.Join(", ", nums) + "]");
        }

        public static int[] SumPairs(int[] nums)
        {
            // sumPairs – sums the elements in the array by pairs (first + second, third + fourth, …).
            // o For example, [1, 2, 4, 5, 6, 7, 8] -> [3, 9, 13, 8].
            int[] result = new int[(int)Math.Ceiling(nums.Length / 2.0)];
            for (int i = 0, j = 0; i < nums.Length; i++)
            {
                result[j] += nums[i];
                if ((i + 1) % 2 == 0)
                {
                    j++;
                }
            }

            return result;
        }

    public static int[] Shift(int[] nums, int positions)
        {
            // shift <positions> – shifts every element of the array the number of positions to the left (with rotation).
            // o For example, [1, 2, 3, 4, 5] -> shift 2 -> [3, 4, 5, 1, 2]
            int[] result = new int[nums.Length];
            for (int i = 0, j = positions; i < nums.Length; i++, j++)
            {
                if (j == nums.Length)
                {
                    j = 0;
                }

                result[i] = nums[j];
            }

            return result;
        }

    public static int[] RemoveIndex(int[] nums, int index)
        {
            // remove <index> – removes the element at the specified index
            int[] result = new int[nums.Length - 1];
            for (int i = 0, j = 0; i < result.Length; i++, j++)
            {
                if (i == index)
                {
                    j++;
                }

                result[i] = nums[j];
            }

            return result;
        }

        public static void PrintIndex(int[] nums, int element)
        {
            // contains <element> – prints the index of the first occurrence of the specified element (if exists) in the array or -1 if the element is not found
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == element)
                {
                    Console.WriteLine(i);
                    return;
                }
            }

            Console.WriteLine(-1);
        }

        public static int[] AddMany(int[] nums, int index, int[] toAdd)
        {
            // addMany <index> <element 1> <element 2> … <element n> – adds a set of elements at the specified index
            int[] result = new int[nums.Length + toAdd.Length];
            for (int i = 0; i < index; i++)
            {
                result[i] = nums[i];
            }

            for (int i = 0; i < toAdd.Length; i++)
            {
                result[i + index] = toAdd[i];
            }

            for (int i = index + toAdd.Length, j = 0 + index; i < result.Length; i++, j++)
            {
                result[i] = nums[j];
            }

            return result;
        }

        public static int[] AddElement(int[] nums, int index, int element)
        {
            // add < index > < element > – adds element at the specified index (elements right from this position inclusively are shifted to the right).
            int[] result = new int[nums.Length + 1];
            for (int i = 0; i < index; i++)
            {
                result[i] = nums[i];
            }

            result[index] = element;
            for (int i = index + 1; i < result.Length; i++)
            {
                result[i] = nums[i - 1];
            }

            return result;
        }
    }
}
