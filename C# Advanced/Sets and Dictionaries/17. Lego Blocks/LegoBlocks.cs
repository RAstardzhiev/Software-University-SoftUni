namespace _17.Lego_Blocks
{
    using System;
    using System.Linq;

    public class LegoBlocks
    {
        public static void Main()
        {
            var numberOfRows = int.Parse(Console.ReadLine());

            var firstJaggedArray = GetJaggedArray(numberOfRows);
            var secondJaggedArray = GetJaggedArray(numberOfRows);

            if (IsFittingPossible(firstJaggedArray, secondJaggedArray))
            {
                for (int i = 0; i < firstJaggedArray.Length; i++)
                {
                    Console.WriteLine($"[{string.Join(", ", firstJaggedArray[i].Concat(secondJaggedArray[i].Reverse()))}]");
                }
            }
            else
            {
                Console.WriteLine($"The total number of cells is: {TotalCellsCount(firstJaggedArray) + TotalCellsCount(secondJaggedArray)}");
            }
        }

        private static int TotalCellsCount(int[][] jaggedArray)
        {
            var cellsCount = 0;

            for (int i = 0; i < jaggedArray.Length; i++)
            {
                cellsCount += jaggedArray[i].Length;
            }

            return cellsCount;
        }

        private static bool IsFittingPossible(int[][] firstJaggedArray, int[][] secondJaggedArray)
        {
            var isFitted = true;

            var upperRowsTotalCellsCount = firstJaggedArray[0].Length + secondJaggedArray[0].Length;

            for (int i = 1; i < firstJaggedArray.Length; i++)
            {
                if (firstJaggedArray[i].Length + secondJaggedArray[i].Length != upperRowsTotalCellsCount)
                {
                    return false;
                }
            }

            return isFitted;
        }

        private static int[][] GetJaggedArray(int numberOfRows)
        {
            var jaggedArray = new int[numberOfRows][];

            for (int i = 0; i < jaggedArray.Length; i++)
            {
                jaggedArray[i] = Console.ReadLine()
                    .Split(new char[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
            }

            return jaggedArray;
        }
    }
}
