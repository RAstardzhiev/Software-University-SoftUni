namespace _12.Legendary_Farming
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class LegendaryFarming
    {
        public static void Main()
        {
            var junkMaterials = new Dictionary<string, int>();
            var keyMaterials = new Dictionary<string, int>();
            keyMaterials["shards"] = 0;
            keyMaterials["fragments"] = 0;
            keyMaterials["motes"] = 0;

            // Collect materials until reach the amount of 250 for some of the key materials
            CollectMaterials(keyMaterials, junkMaterials);

            // Print the legendary item
            Console.WriteLine($"{ObtainLegendary(keyMaterials)} obtained!");

            // Print remaining key mateirals
            PrintMaterials(keyMaterials.OrderByDescending(m => m.Value).ThenBy(m => m.Key));

            // Print collected junk materials
            PrintMaterials(junkMaterials.OrderBy(m => m.Key));
        }

        private static void PrintMaterials(IOrderedEnumerable<KeyValuePair<string, int>> materials)
        {

            foreach (var material in materials)
            {
                Console.WriteLine($"{material.Key}: {material.Value}");
            }
        }

        private static string ObtainLegendary(Dictionary<string, int> keyMaterials)
        {
            var materialName = keyMaterials
                .Where(kvp => kvp.Value >= 250)
                .First()
                .Key;

            // Remove 250 from the amount to obtain the legendary item
            keyMaterials[materialName] -= 250;

            // Find which is the legendary item obtained
            switch (materialName)
            {
                case "shards":
                    return "Shadowmourne";
                case "fragments":
                    return "Valanyr";
                case "motes":
                    return "Dragonwrath";
                default:
                    return "Big ERROR!!! Please call the developer. *** Big ERROR!!! *** Nothing";
            }
        }

        private static void CollectMaterials(Dictionary<string, int> keyMaterials, Dictionary<string, int> junkMaterials)
        {
            while (true)
            {
                var input = Console.ReadLine()
                    .ToLower()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < input.Length; i++)
                {
                    var quantity = int.Parse(input[i]);
                    i++;
                    var material = input[i];

                    if (keyMaterials.ContainsKey(material))
                    {
                        keyMaterials[material] += quantity;

                        if (keyMaterials[material] >= 250)
                        {
                            return;
                        }
                    }
                    else
                    {
                        if (!junkMaterials.ContainsKey(material))
                        {
                            junkMaterials[material] = 0;
                        }

                        junkMaterials[material] += quantity;
                    }
                }
            }
        }
    }
}
