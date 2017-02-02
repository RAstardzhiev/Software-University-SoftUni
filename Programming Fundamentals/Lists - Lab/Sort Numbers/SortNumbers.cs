namespace Sort_Numbers
{
    using System;
    using System.Collections.Generic;

    public class SortNumbers
    {
        public static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            List<double> nums = new List<double>();
            foreach (var num in input)
            {
                nums.Add(double.Parse(num));
            }

            nums.Sort();
            Console.WriteLine(string.Join(" <= ", nums));
        }
    }
}
