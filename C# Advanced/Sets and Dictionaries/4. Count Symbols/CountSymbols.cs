namespace _4.Count_Symbols
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CountSymbols
    {
        public static void Main()
        {
            var text = Console.ReadLine().ToCharArray();
            var dict = new SortedDictionary<char, int>();

            foreach (var symbol in text)
            {
                if (!dict.ContainsKey(symbol))
                {
                    dict[symbol] = 0;
                }

                dict[symbol]++;
            }

            Console.WriteLine(string.Join(Environment.NewLine, dict
                .Select(kvp => $"{kvp.Key}: {kvp.Value} time/s")));
        }
    }
}
