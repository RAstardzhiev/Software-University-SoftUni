namespace _7.Lego_Blocks
{
    using System;
    using System.Linq;

    public class LegoBlocks
    {
        public static void Main()
        {
            var rows = int.Parse(Console.ReadLine());
            var firstMatrix = ReadInput(rows);
            var secondMatrix = ReadInput(rows).Select(r => r.Reverse().ToArray()).ToArray();
            PrintResult(firstMatrix, secondMatrix);
        }

        private static void PrintResult(int[][] firstMatrix, int[][] secondMatrix)
        {
            if (IsRectangularMatrix(firstMatrix, secondMatrix))
            {
                for (int i = 0; i < firstMatrix.Length; i++)
                {
                    Console.WriteLine($"[{string.Join(", ", firstMatrix[i].Concat(secondMatrix[i]))}]");
                }
            }
            else
            {
                Console.WriteLine($"The total number of cells is: {CellsCount(firstMatrix, secondMatrix)}");
            }
        }

        private static object CellsCount(int[][] firstMatrix, int[][] secondMatrix)
        {
            var numberOfCells = 0;

            for (int i = 0; i < firstMatrix.Length; i++)
            {
                numberOfCells += firstMatrix[i].Length + secondMatrix[i].Length;
            }

            return numberOfCells;
        }

        private static bool IsRectangularMatrix(int[][] firstMatrix, int[][] secondMatrix)
        {
            for (int i = 1; i < firstMatrix.Length; i++)
            {
                if (firstMatrix[i].Length + secondMatrix[i].Length !=
                    firstMatrix[i - 1].Length + secondMatrix[i - 1].Length)
                {
                    return false;
                }
            }

            return true;
        }

        private static int[][] ReadInput(int rows)
        {
            var matrix = new int[rows][];

            for (int i = 0; i < matrix.Length; i++)
            {
                matrix[i] = Console.ReadLine()
                    .Split(new char[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
            }

            return matrix;
        }
    }
}
