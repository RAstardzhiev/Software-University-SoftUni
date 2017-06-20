namespace _04.Ashes_of_Roses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;

    public class AshesOfRoses
    {
        public static void Main()
        {
            var regionsWithRoses = GetRoseStatistics();
            PrintStatistics(regionsWithRoses);
        }

        private static void PrintStatistics(Dictionary<string, HashSet<Rosse>> regionsWithRoses)
        {
            var stat = new StringBuilder();

            foreach (var region in regionsWithRoses
                .OrderByDescending(reg => reg.Value.Select(rose => rose.Amount).Sum())
                .ThenBy(reg => reg.Key))
            {
                stat.Append(region.Key);
                stat.Append(Environment.NewLine);

                foreach (var rose in region.Value
                    .OrderBy(r => r.Amount)
                    .ThenBy(r => r.Color))
                {
                    stat.Append($"*--{rose.Color} | {rose.Amount}{Environment.NewLine}");
                }
            }

            Console.Write(stat);
        }

        private static new Dictionary<string, HashSet<Rosse>> GetRoseStatistics()
        {
            var regionsWithRoses = new Dictionary<string, HashSet<Rosse>>();
            var regex = new Regex("^Grow <[A-Z][a-z]+> <[A-Za-z0-9]+> [0-9]+$");
            var input = Console.ReadLine();

            while (input != "Icarus, Ignite!")
            {
                if (!regex.IsMatch(input))
                {
                    input = Console.ReadLine();
                    continue;
                }

                var regionData = input.Split(' ');

                var region = regionData[1].Trim('<', '>');
                var color = regionData[2].Trim('<', '>');
                var amount = int.Parse(regionData[3]);

                if (!regionsWithRoses.ContainsKey(region))
                {
                    regionsWithRoses[region] = new HashSet<Rosse>();
                }

                if (!regionsWithRoses[region].Any(r => r.Color  == color))
                {
                    regionsWithRoses[region].Add(new Rosse { Color = color, Amount = 0 });
                }

                regionsWithRoses[region].Where(r => r.Color == color).First().Amount += amount;

                input = Console.ReadLine();
            }

            return regionsWithRoses;
        }
    }
}
