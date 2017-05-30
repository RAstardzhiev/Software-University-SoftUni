namespace _2.Maximum_sum_of_2x2_submatrix
{
    using System;
    using System.Linq;

    public class MaximumSumTwoByTwoSubmatrix
    {
        public static void Main()
        {
            var matrix = GetMatrixFromConsole();

            if (matrix == null)
            {
                Console.WriteLine($"0{Environment.NewLine}0{Environment.NewLine}0");
                return;
            }

            PrintMatrixResult(matrix);
        }

        private static void PrintMatrixResult(int[][] matrix)
        {
            var resultStartAt = new int[2];
            var biggestSum = int.MinValue;

            for (int i = 0; i < matrix.Length - 1; i++)
            {
                for (int j = 0; j < matrix[i].Length - 1; j++)
                {
                    var testSum = matrix[i][j] + matrix[i][j + 1] + matrix[i + 1][j] + matrix[i + 1][j + 1];

                    if (testSum > biggestSum)
                    {
                        biggestSum = testSum;
                        resultStartAt[0] = i;
                        resultStartAt[1] = j;
                    }
                }
            }

            Console.WriteLine($"{matrix[resultStartAt[0]][resultStartAt[1]]} {matrix[resultStartAt[0]][resultStartAt[1] + 1]}{Environment.NewLine}{matrix[resultStartAt[0] + 1][resultStartAt[1]]} {matrix[resultStartAt[0] + 1][resultStartAt[1] + 1]}");
            Console.WriteLine(biggestSum);
        }

        private static int[][] GetMatrixFromConsole()
        {
            var dimmensions = Console.ReadLine()
                .Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            if (dimmensions.Length < 2)
            {
                return null;
            }

            var matrix = new int[dimmensions[0]][];

            for (int i = 0; i < matrix.Length; i++)
            {
                matrix[i] = Console.ReadLine()
                    .Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .Take(dimmensions[1])
                    .ToArray();
            }

            return matrix;
        }
    }
}
