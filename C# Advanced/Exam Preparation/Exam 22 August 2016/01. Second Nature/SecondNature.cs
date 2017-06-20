namespace _01.Second_Nature
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SecondNature
    {
        public static void Main()
        {
            var dust = new Stack<int>(Console.ReadLine()
                .Split(new char[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .Reverse());

            var water = new Stack<int>(Console.ReadLine()
                .Split(new char[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse));

            var secondNatureFlower = WaterFlowers(dust, water);
            PrintResult(water, secondNatureFlower, dust);
        }

        private static Queue<int> WaterFlowers(Stack<int> dust, Stack<int> water)
        {
            var secondNatureFlower = new Queue<int>();

            while (dust.Count > 0 && water.Count > 0)
            {
                if (water.Peek() < dust.Peek()) // Water is not enough)
                {
                    dust.Push(dust.Pop() - water.Pop()); // Update Dust value
                }
                else if (water.Peek() == dust.Peek()) // add Second Nature Flower
                {
                    secondNatureFlower.Enqueue(dust.Pop());
                    water.Pop();
                }
                else // water is more than needed
                {
                    GetBackRemainingWater(water.Pop() - dust.Pop(), water);
                }
            }

            return secondNatureFlower;
        }

        private static void GetBackRemainingWater(int remainintWater, Stack<int> water)
        {
            if (remainintWater > 0)
            {
                if (water.Any())
                {
                    water.Push(water.Pop() + remainintWater);
                }
                else
                {
                    water.Push(remainintWater);
                }
            }
        }

        private static void PrintResult(Stack<int> water, Queue<int> secondNatureFlower, Stack<int> dust)
        {
            Console.WriteLine((water.Any())
                ? string.Join(" ", water)
                : string.Join(" ", dust));

            Console.WriteLine((secondNatureFlower.Any())
                ? string.Join(" ", secondNatureFlower)
                : "None");
        }
    }
}
