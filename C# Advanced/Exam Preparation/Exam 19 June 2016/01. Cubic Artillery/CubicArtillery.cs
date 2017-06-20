namespace _01.Cubic_Artillery
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class CubicArtillery
    {
        public static StringBuilder recisionResult = new StringBuilder();

        public static void Main()
        {
            var bunkersCapacity = int.Parse(Console.ReadLine());
            var bunkers = new Queue<Bunker>();

            var input = Console.ReadLine();

            while (input != "Bunker Revision")
            {
                var data = input.Split();
                ProcessData(data, bunkers, ref bunkersCapacity);
                input = Console.ReadLine();
            }

            Console.Write(recisionResult);
        }

        private static void ProcessData(string[] data, Queue<Bunker> bunkers, ref int bunkersCapacity)
        {
            foreach (var item in data)
            {
                int weaponSize;
                bool isDigit = int.TryParse(item, out weaponSize);

                if (!isDigit)
                {
                    bunkers.Enqueue(new Bunker
                    {
                        Name = item,
                        UsedSpace = 0,
                        Weapons = new Queue<int>()
                    });

                    continue;
                }
                else if (bunkers.Count == 1 && weaponSize <= bunkersCapacity)
                {
                    bunkers.Peek().UsedSpace += weaponSize;
                    bunkers.Peek().Weapons.Enqueue(weaponSize);

                    while (bunkers.Peek().UsedSpace > bunkersCapacity)
                    {
                        bunkers.Peek().UsedSpace -= bunkers.Peek().Weapons.Dequeue();
                    }
                }
                else
                {
                    while (bunkers.Count > 1)
                    {
                        if (bunkers.Peek().UsedSpace + weaponSize <= bunkersCapacity)
                        {
                            bunkers.Peek().UsedSpace += weaponSize;
                            bunkers.Peek().Weapons.Enqueue(weaponSize);
                            break;
                        }
                        else
                        {
                            AppendBunker(bunkers.Dequeue());
                        }
                    }
                }

                if (bunkers.Count > 1 && bunkers.Peek().UsedSpace == bunkersCapacity)
                {
                    AppendBunker(bunkers.Dequeue());
                }
            }
        }

        private static void AppendBunker(Bunker bunker)
        {
            recisionResult.Append((bunker.UsedSpace == 0)
                    ? $"{bunker.Name} -> Empty"
                    : $"{bunker.Name} -> {string.Join(", ", bunker.Weapons)}");

            recisionResult.Append(Environment.NewLine);
        }
    }
}
