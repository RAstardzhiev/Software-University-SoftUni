namespace _4.Maximal_Sum
{
    using System;
    using System.Linq;

    public class MaximalSum
    {
        public static void Main()
        {
            var matrix = InitializeMatrix();
            Print3x3SubmatrixWithBiggestSum(matrix);
        }

        private static void Print3x3SubmatrixWithBiggestSum(int[][] matrix)
        {
            var biggestSum = int.MinValue;
            var resultStartIndex = new int[2];

            for (int i = 0; i < matrix.Length - 2; i++)
            {
                for (int j = 0; j < matrix[i].Length - 2; j++)
                {
                    var testSum = matrix[i][j] + matrix[i][j + 1] + matrix[i][j + 2] +
                        matrix[i + 1][j] + matrix[i + 1][j + 1] + matrix[i + 1][j + 2] +
                        matrix[i + 2][j] + matrix[i + 2][j + 1] + matrix[i + 2][j + 2];

                    if (testSum > biggestSum)
                    {
                        biggestSum = testSum;
                        resultStartIndex[0] = i;
                        resultStartIndex[1] = j;
                    }
                }
            }

            Console.WriteLine($"Sum = {biggestSum}");
            Console.WriteLine(string.Join(Environment.NewLine, matrix
                .Skip(resultStartIndex[0])
                .Take(3)
                .Select(row => string.Join(" ", row.Skip(resultStartIndex[1]).Take(3)))));
        }

        private static int[][] InitializeMatrix()
        {
            var dimensions = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var matrix = new int[dimensions[0]][];

            for (int i = 0; i < matrix.Length; i++)
            {
                matrix[i] = Console.ReadLine().Split().Take(dimensions[1]).Select(int.Parse).ToArray();
            }

            return matrix;
        }
    }
}
