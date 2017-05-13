namespace _19.Crossfire
{
    using System;
    using System.Linq;

    public class Crossfire
    {
        public static void Main()
        {
            var matrix = InitializeMatrix();
            matrix = ExecuteCommands(matrix);
            PrintAliveCells(matrix);
        }

        private static void PrintAliveCells(int[][] matrix)
        {
            for (int i = 0; i < matrix.Length; i++)
            {
                Console.WriteLine(string.Join(" ", matrix[i]));
            }
        }

        private static int[][] ExecuteCommands(int[][] matrix)
        {
            var command = Console.ReadLine().Trim();

            while (command != "Nuke it from orbit")
            {
                var commandDetails = command
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                var hitRow = commandDetails[0];
                var hitColumn = commandDetails[1];
                var hitWaveRadius = commandDetails[2];

                matrix = DestroyMatrix(matrix, hitRow, hitColumn, hitWaveRadius);

                command = Console.ReadLine().Trim();
            }

            return matrix;
        }

        private static int[][] DestroyMatrix(int[][] matrix, int hitRow, int hitCol, int hitWave)
        {
            // Mark destroyed cells
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    if ((i == hitRow) && (j == hitCol) ||
                        (i == hitRow) && (j >= hitCol - hitWave) && (j <= hitCol + hitWave) ||
                        (j == hitCol) && (i >= hitRow - hitWave) && (i <= hitRow + hitWave))
                    {
                        matrix[i][j] = -1;
                    }
                }
            }

            // Remove destroyed cells
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    if (matrix[i][j] == -1)
                    {
                        matrix[i] = matrix[i].Where(n => n > 0).ToArray();
                        break;
                    }
                }

                // Check for empty row
                if (matrix[i].Count() < 1)
                {
                    matrix = matrix.Take(i).Concat(matrix.Skip(i + 1)).ToArray();
                    i--;
                }
            }

            return matrix;
        }

        private static int[][] InitializeMatrix()
        {
            var dimensions = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var currentCellNumber = 1;
            var matrix = new int[dimensions[0]][];

            for (int i = 0; i < matrix.Length; i++)
            {
                matrix[i] = new int[dimensions[1]];

                for (int j = 0; j < matrix[i].Length; j++)
                {
                    matrix[i][j] = currentCellNumber;
                    currentCellNumber++;
                }
            }

            return matrix;
        }
    }
}
