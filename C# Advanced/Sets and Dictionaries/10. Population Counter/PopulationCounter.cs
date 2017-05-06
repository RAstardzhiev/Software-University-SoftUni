namespace _10.Population_Counter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class PopulationCounter
    {
        public static void Main()
        {
            Dictionary<string, Dictionary<string, long>> statistics = CollectData();

            foreach (var country in statistics.OrderByDescending(country => country.Value.Values.Sum()))
            {
                Console.WriteLine($"{country.Key} (total population: {country.Value.Values.Sum()})");
                foreach (var city in country.Value.OrderByDescending(city => city.Value))
                {
                    Console.WriteLine($"=>{city.Key}: {city.Value}");
                }
            }
        }

        private static Dictionary<string, Dictionary<string, long>> CollectData()
        {
            var statistics = new Dictionary<string, Dictionary<string, long>>();

            var data = Console.ReadLine().Split('|');

            while (data[0] != "report")
            {
                var city = data[0];
                var country = data[1];
                var population = long.Parse(data[2]);

                if (!statistics.ContainsKey(country))
                {
                    statistics[country] = new Dictionary<string, long>();
                }

                if (!statistics[country].ContainsKey(city))
                {
                    statistics[country][city] = 0;
                }

                statistics[country][city] += population;

                data = Console.ReadLine().Split('|');
            }

            return statistics;
        }
    }
}
