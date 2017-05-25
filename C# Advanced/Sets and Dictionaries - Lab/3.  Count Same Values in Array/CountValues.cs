namespace _3.Count_Same_Values_in_Array
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;

    public class CountValues
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(n => double.Parse(n, CultureInfo.InvariantCulture))
                .ToArray();

            var counter = new SortedDictionary<double, int>();

            foreach (var digit in numbers)
            {
                if (!counter.ContainsKey(digit))
                {
                    counter[digit] = 0;
                }

                counter[digit]++;
            }

            Console.WriteLine(string.Join(Environment.NewLine, counter.Select(x => $"{x.Key} - {x.Value} times")));
        }
    }
}
