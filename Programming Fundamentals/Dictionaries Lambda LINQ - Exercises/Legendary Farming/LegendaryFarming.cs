namespace Legendary_Farming
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class LegendaryFarming
    {
        public static void Main(string[] args)
        {
            Dictionary<string, int> keyResources = new Dictionary<string, int>()
            {
                { "shards", 0 }, { "fragments", 0 }, { "motes", 0 }
            };
            Dictionary<string, int> junkItems = new Dictionary<string, int>();
            PrintWinner(keyResources, junkItems);

            foreach (var item in keyResources.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

            foreach (var item in junkItems.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }

        private static void PrintWinner(Dictionary<string, int> keyResources, Dictionary<string, int> junkItems)
        {
            string acheivment = CollectResources(keyResources, junkItems);
            switch (acheivment)
            {
                case "shards":
                    Console.WriteLine("Shadowmourne obtained!");
                    break;
                case "fragments":
                    Console.WriteLine("Valanyr obtained!");
                    break;
                case "motes":
                    Console.WriteLine("Dragonwrath obtained!");
                    break;
                default:
                    break;
            }

            keyResources[acheivment] -= 250;
        }

        private static string CollectResources(Dictionary<string, int> keyResources, Dictionary<string, int> junkItems)
        {
            while (true)
            {
                // • Each line of input is in format {quantity} {material} {quantity} {material} … {quantity} {material}
                string[] input = Console.ReadLine().ToLower().Split(' ');
                for (int i = 0; i < input.Length - 1; i += 2)
                {
                    if (keyResources.ContainsKey(input[i + 1]))
                    {
                        keyResources[input[i + 1]] += int.Parse(input[i]);
                    }
                    else
                    {
                        if (junkItems.ContainsKey(input[i + 1]))
                        {
                            junkItems[input[i + 1]] += int.Parse(input[i]);
                        }
                        else
                        {
                            junkItems[input[i + 1]] = int.Parse(input[i]);
                        }
                    }

                    foreach (KeyValuePair<string, int> item in keyResources)
                    {
                        if (item.Value >= 250)
                        {
                            return item.Key;
                        }
                    }
                }
            }
        }
    }
}
