namespace _1.Sum_Matrix_Elements
{
    using System;
    using System.Linq;

    public class SumMatrixElements
    {
        public static void Main()
        {
            var matrix = GetMatrixFromConsole();

            if (matrix == null)
            {
                Console.WriteLine($"0{Environment.NewLine}0{Environment.NewLine}0");
            }
            else
            {
                Console.WriteLine(matrix.Length);
                Console.WriteLine(matrix[0].Length);
                Console.WriteLine(matrix.Select(row => row.Sum()).Sum());
            }
        }

        private static int[][] GetMatrixFromConsole()
        {
            var dimmensions = Console.ReadLine()
                .Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
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
