namespace Dragon_Army
{
    using System;
    using System.Collections.Generic;

    public class DragonArmy
    {
        public static void Main(string[] args)
        {
            byte n = byte.Parse(Console.ReadLine());
            Dictionary<string, SortedDictionary<string, int[]>> dragons = new Dictionary<string, SortedDictionary<string, int[]>>();
            GetDragonsData(dragons, n);
            PrintDragonsStatistics(dragons);
        }

        private static void PrintDragonsStatistics(Dictionary<string, SortedDictionary<string, int[]>> dragons)
        {
            foreach (KeyValuePair<string, SortedDictionary<string, int[]>> type in dragons)
            {
                // {Type}::({damage}/{health}/{armor})
                Console.WriteLine($"{type.Key}::({GetAvarage(type.Value, 0):F2}/{GetAvarage(type.Value, 1):F2}/{GetAvarage(type.Value, 2):F2})");

                foreach (KeyValuePair<string, int[]> dragon in type.Value)
                {
                    // -{Name} -> damage: {damage}, health: {health}, armor: {armor}
                    Console.WriteLine($"-{dragon.Key} -> damage: {dragon.Value[0]}, health: {dragon.Value[1]}, armor: {dragon.Value[2]}");
                }
            }
        }

        private static double GetAvarage(SortedDictionary<string, int[]> dragonsType, int neededAvarage)
        {
            double sum = 0.0;

            foreach (int[] value in dragonsType.Values)
            {
                sum += value[neededAvarage];
            }

            return sum / dragonsType.Count;
        }

        private static void GetDragonsData(Dictionary<string, SortedDictionary<string, int[]>> dragons, byte n)
        {
            for (byte i = 0; i < n; i++)
            {
                // input: Red Bazgargal 100 2500 25
                // => type, name, damage, health, armor
                string[] input = Console.ReadLine().Split(' ');
                if (!dragons.ContainsKey(input[0]))
                {
                    dragons[input[0]] = new SortedDictionary<string, int[]>();
                }

                dragons[input[0]][input[1]] = new int[3];

                // Default values are as follows: damage 45, health 250, and armor 10
                dragons[input[0]][input[1]][0] = (input.Length >= 3 && !input[2].ToLower().Equals("null")) ? int.Parse(input[2]) : 45;
                dragons[input[0]][input[1]][1] = (input.Length >= 4 && !input[3].ToLower().Equals("null")) ? int.Parse(input[3]) : 250;
                dragons[input[0]][input[1]][2] = (input.Length >= 5 && !input[4].ToLower().Equals("null")) ? int.Parse(input[4]) : 10;
            }
        }
    }
}
