namespace Population_Counter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class PopulationCounter
    {
        public static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, long>> populations = new Dictionary<string, Dictionary<string, long>>();

            while (true)
            {
                string[] input = Console.ReadLine().Split('|');
                if (input[0].ToLower().Equals("report"))
                {
                    break;
                }

                // Input: Sofia|Bulgaria|1
                if (!populations.ContainsKey(input[1]))
                {
                    populations[input[1]] = new Dictionary<string, long>();
                }

                populations[input[1]][input[0]] = long.Parse(input[2]);
            }

            populations = populations
                .OrderByDescending(x => x.Value.Values.Sum())
                .ToDictionary(x => x.Key, x => x.Value);

            PrintDicts(populations);
        }

        private static long GetTotalPopulation(Dictionary<string, long> cities)
        {
            long sum = 0L;
            foreach (int people in cities.Values)
            {
                sum += people;
            }

            return sum;
        }

        private static void PrintDicts(Dictionary<string, Dictionary<string, long>> populations)
        {
            foreach (KeyValuePair<string, Dictionary<string, long>> country in populations)
            {
                Console.WriteLine("{0} (total population: {1})", country.Key, GetTotalPopulation(country.Value));
                foreach (KeyValuePair<string, long> city in country.Value.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value))
                {
                    Console.WriteLine($"=>{city.Key}: {city.Value}");
                }
            }
        }
    }
}
