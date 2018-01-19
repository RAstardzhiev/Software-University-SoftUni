namespace _05._Count_of_Occurrences
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse);

            var counter = new Dictionary<int, int>();

            foreach (var num in numbers)
            {
                if (!counter.ContainsKey(num))
                {
                    counter[num] = 1;
                }
                else
                {
                    counter[num]++;
                }
            }

            Console.WriteLine(string.Join(Environment.NewLine, counter
                .OrderBy(kvp => kvp.Key)
                .Select(kvp => $"{kvp.Key} -> {kvp.Value} times")));
        }
    }
}
