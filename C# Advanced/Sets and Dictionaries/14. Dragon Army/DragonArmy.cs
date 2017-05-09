namespace _14.Dragon_Army
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class DragonArmy
    {
        public static void Main()
        {
            // Key is Dragon Type / Value is all the rest information
            Dictionary<string, SortedSet<Dragon>> dragons = GetInput();
            PrintDragons(dragons);
        }

        private static void PrintDragons(Dictionary<string, SortedSet<Dragon>> dragons)
        {
            foreach (var type in dragons)
            {
                /* 
                 * For each type, print average stats of its dragons in format: 
                 * -{Type}::({damage}/{health}/{armor})
                 */
                var damageAverage = type.Value.Select(d => d.Damage).Average();
                var healthAverage = type.Value.Select(h => h.Health).Average();
                var armorAverage = type.Value.Select(a => a.Armor).Average();
                Console.WriteLine($"{type.Key}::({damageAverage:F2}/{healthAverage:F2}/{armorAverage:F2})");

                /*
                 * For each dragon, print its stats in format:
                 * {Name} -> damage: {damage}, health: {health}, armor: {armor}
                 */
                foreach (var dragon in type.Value)
                {
                    Console.WriteLine($"-{dragon.Name} -> damage: {dragon.Damage}, health: {dragon.Health}, armor: {dragon.Armor}");
                }
            }
        }

        private static Dictionary<string, SortedSet<Dragon>> GetInput()
        {
            var n = int.Parse(Console.ReadLine());
            var dragons = new Dictionary<string, SortedSet<Dragon>>(n);

            for (int i = 0; i < n; i++)
            {
                // Input format: {type} {name} {damage} {health} {armor}
                var input = new Stack<string>(Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));

                // Default Armor value = 10
                var armor = (input.Peek() == "null") ? 10 : int.Parse(input.Peek());
                input.Pop();

                // Default Health value = 250
                var health = (input.Peek() == "null") ? 250 : int.Parse(input.Peek());
                input.Pop();

                // Default Damage value = 45
                var damage = (input.Peek() == "null") ? 45 : int.Parse(input.Peek());
                input.Pop();

                var name = input.Pop();
                var type = input.Pop();

                if (!dragons.ContainsKey(type))
                {
                    dragons[type] = new SortedSet<Dragon>(new DragonComparer());
                }

                bool isNewDragon = dragons[type].Where(d => d.Name == name).FirstOrDefault() == null;

                if (isNewDragon)
                {
                    // If the dragon is new one add it to the collection
                    dragons[type].Add(new Dragon()
                    {
                        Name = name,
                        Armor = armor,
                        Damage = damage,
                        Health = health
                    });
                }
                else
                {
                    // If the same dragon is added a second time, overwrite the previous ones
                    foreach (var dragon in dragons[type])
                    {
                        if (dragon.Name == name)
                        {
                            dragon.Armor = armor;
                            dragon.Damage = damage;
                            dragon.Health = health;
                        }
                    }
                }
            }

            return dragons;
        }
    }
}
