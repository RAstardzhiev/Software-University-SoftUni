namespace _04.Cubic_Assault
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class CubicAssault
    {
        private const int TransformationBorder = 1000000;
        private static string[] MeteorTypes = new string[] { "Green", "Red", "Black" };

        public static void Main()
        {
            var regions = GetStatistics();
            PrintRegions(regions);
        }

        private static void PrintRegions(Dictionary<string, Dictionary<string, long>> regions)
        {
            var sb = new StringBuilder();
            var valueToAdd = 0;

            foreach (var region in regions
                    .OrderByDescending(r => r.Value["Black"])
                    .ThenBy(r => r.Key.Length)
                    .ThenBy(r => r.Key))
            {
                sb.Append(region.Key);
                sb.Append(Environment.NewLine);

                foreach (var meteorType in region.Value
                        .OrderByDescending(m => m.Value)
                        .ThenBy(m => m.Key))
                {

                    sb.Append($"-> {meteorType.Key} : {meteorType.Value}");
                    sb.Append(Environment.NewLine);
                }
            }

            Console.Write(sb);
        }

        private static Dictionary<string, Dictionary<string, long>> GetStatistics()
        {
            var regions = new Dictionary<string, Dictionary<string, long>>();
            var input = Console.ReadLine()
                .Split(new[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);

            while (input[0] != "Count em all")
            {
                if (!regions.ContainsKey(input[0]))
                {
                    regions[input[0]] = new Dictionary<string, long>()
                    {
                        { "Green", 0L },
                        { "Red", 0L },
                        { "Black", 0L }
                    };
                }

                regions[input[0]][input[1]] += long.Parse(input[2]);

                if (regions[input[0]][input[1]] >= TransformationBorder)
                {
                    TransformMeteor(regions, input[0]);
                }

                input = Console.ReadLine()
                .Split(new[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
            }

            return regions; ;
        }

        private static void TransformMeteor(Dictionary<string, Dictionary<string, long>> regions, string region)
        {
            if (regions[region][MeteorTypes[0]] >= TransformationBorder)
            {
                regions[region][MeteorTypes[1]] += regions[region][MeteorTypes[0]] / TransformationBorder;
                regions[region][MeteorTypes[0]] %= TransformationBorder;
            }

            if (regions[region][MeteorTypes[1]] >= TransformationBorder)
            {
                regions[region][MeteorTypes[2]] += regions[region][MeteorTypes[1]] / TransformationBorder;
                regions[region][MeteorTypes[1]] %= TransformationBorder;
            }
        }
    }
}
