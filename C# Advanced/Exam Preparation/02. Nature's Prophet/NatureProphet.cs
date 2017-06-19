namespace _02.Nature_s_Prophet
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class NatureProphet
    {
        public static void Main()
        {
            var gardern = SetGarder();
            var plants = GertPlants(gardern);
            BloomFlowers(gardern, plants);
            Console.WriteLine(string.Join(Environment.NewLine, gardern
                .Select(row => string.Join(" ", row))));
        }

        private static void BloomFlowers(int[][] gardern, int[][] plants)
        {
            foreach (var position in plants)
            {
                BloomHorizontal(gardern, position);
                BloomVertical(gardern, position);
            }
        }

        private static void BloomVertical(int[][] gardern, int[] position)
        {
            for (int row = 0; row < gardern.Length; row++)
            {
                gardern[row][position[1]]++;
            }
        }

        private static void BloomHorizontal(int[][] gardern, int[] position)
        {
            for (int col = 0; col < gardern[position[0]].Length; col++)
            {
                if (col != position[1])
                {
                    gardern[position[0]][col]++;
                }
            }
        }

        private static int[][] GertPlants(int[][] gardern)
        {
            var plants = new Stack<int[]>();
            var input = Console.ReadLine();

            while (input != "Bloom Bloom Plow")
            {
                var position = input.Split().Select(int.Parse).ToArray();
                plants.Push(new int[] { position[0], position[1] });

                input = Console.ReadLine();
            }

            return plants
                .OrderBy(a => a[0])
                .ThenBy(a => a[1])
                .ToArray();
        }

        private static int[][] SetGarder()
        {
            var dimensions = Console.ReadLine().Split().Select(int.Parse).ToArray();
            return new int[dimensions[0]][]
                .Select(row => row = new int[dimensions[1]]).ToArray();
        }
    }
}
