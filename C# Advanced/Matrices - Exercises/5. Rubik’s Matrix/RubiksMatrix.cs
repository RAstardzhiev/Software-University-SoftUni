namespace _5.Rubik_s_Matrix
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class RubiksMatrix
    {
        public static void Main()
        {
            var matrix = InitializeMatrix();
            ExecuteCommands(matrix);
            Console.Write(GetRearangementSwaps(matrix));
        }

        private static string GetRearangementSwaps(int[][] matrix)
        {
            var sb = new StringBuilder();
            var expectedValue = 1;

            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    if (matrix[i][j] != expectedValue)
                    {
                        sb.Append(Swap(matrix, i, j, expectedValue));
                    }
                    else
                    {
                        sb.Append($"No swap required{Environment.NewLine}");
                    }

                    expectedValue++;
                }
            }

            return sb.ToString();
        }

        private static string Swap(int[][] matrix, int row, int col, int expectedValue)
        {
            for (int i = row; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    if (matrix[i][j] == expectedValue)
                    {
                        var temp = matrix[i][j];
                        matrix[i][j] = matrix[row][col];
                        matrix[row][col] = temp;

                        return $"Swap ({row}, {col}) with ({i}, {j}){Environment.NewLine}";
                    }
                }
            }

            return string.Empty;
        }

        private static void ExecuteCommands(int[][] matrix)
        {
            var numbverOfCommands = int.Parse(Console.ReadLine());

            while (numbverOfCommands > 0)
            {
                // Commands format: {row/col} {direction} {moves}
                var command = Console.ReadLine().Split();
                RotateMatrix(matrix, int.Parse(command[0]), command[1], int.Parse(command[2]));
                numbverOfCommands--;
            }
        }

        private static void RotateMatrix(int[][] matrix, int rowCol, string direction, int moves)
        {
            switch (direction.ToLower())
            {
                case "up":
                    var rowBecomingFirst = moves % matrix.Length;

                    if (rowBecomingFirst != 0)
                    {
                        RotateColumn(matrix, rowCol, rowBecomingFirst);
                    }

                    break;
                case "down":
                    rowBecomingFirst = (moves % matrix.Length == 0) 
                        ? 0 
                        : matrix.Length - (moves % matrix.Length);

                    if (rowBecomingFirst != 0)
                    {
                        RotateColumn(matrix, rowCol, rowBecomingFirst);
                    }

                    break;
                case "left":
                    var colBecomingFirst = moves % matrix[rowCol].Length;

                    if (colBecomingFirst != 0)
                    {
                        RotateRow(matrix, rowCol, colBecomingFirst);
                    }

                    break;
                case "right":
                    colBecomingFirst = (moves % matrix[rowCol].Length == 0) 
                        ? 0 
                        : matrix[rowCol].Length - (moves % matrix[rowCol].Length);

                    if (colBecomingFirst != 0)
                    {
                        RotateRow(matrix, rowCol, colBecomingFirst);
                    }

                    break;
                default:
                    break;
            }
        }

        private static void RotateRow(int[][] matrix, int row, int col)
        {
            var newValues = new Queue<int>(matrix[row].Length);

            for (int j = 0; j < matrix[row].Length; j++)
            {
                if (col == matrix[row].Length)
                {
                    col = 0;
                }

                newValues.Enqueue(matrix[row][col]);
                col++;
            }

            matrix[row] = newValues.ToArray();
        }

        private static void RotateColumn(int[][] matrix, int col, int row)
        {
            var newValues = new Queue<int>(matrix.Length);

            while (newValues.Count < matrix.Length)
            {
                if (row == matrix.Length)
                {
                    row = 0;
                }

                newValues.Enqueue(matrix[row][col]);
                row++;
            }

            for (int i = 0; i < matrix.Length; i++)
            {
                matrix[i][col] = newValues.Dequeue();
            }
        }

        private static int[][] InitializeMatrix()
        {
            var dimensions = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var matrix = new int[dimensions[0]][].Select(r => r = new int[dimensions[1]]).ToArray();

            var cellValue = 1;

            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    matrix[i][j] = cellValue;
                    cellValue++;
                }
            }

            return matrix;
        }
    }
}
