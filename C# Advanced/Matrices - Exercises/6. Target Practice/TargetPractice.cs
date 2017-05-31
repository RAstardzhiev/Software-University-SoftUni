namespace _6.Target_Practice
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class TargetPractice
    {
        public static void Main()
        {
            var stairs = InitializeMAtrix();
            ShotOnSnake(stairs);
            Console.WriteLine(string.Join(Environment.NewLine, stairs.Select(r => string.Join(string.Empty, r))));
        }

        private static void ShotOnSnake(char[][] matrix)
        {
            var shotData = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var impactRow = shotData[0];
            var impactCol = shotData[1];
            var impactRadius = shotData[2];

            for (int i = 0; i < matrix.Length; i++) // Process shot impact
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    if (IsCellShooted(i, j, impactRow, impactCol, impactRadius))
                    {
                        matrix[i][j] = ' ';
                    }
                }
            }

            for (int j = 0; j < matrix[0].Length; j++) // Fall down all cells above the impact zone
            {
                for (int i = matrix.Length - 1; i > 0; i--)
                {
                    if (matrix[i][j] == ' ' && matrix[i - 1][j] != ' ')
                    {
                        CellFallsDown(matrix, i, j);
                    }
                }
            }
        }

        private static void CellFallsDown(char[][] matrix, int row, int col)
        {
            while (row < matrix.Length)
            {
                if (matrix[row][col] == ' ')
                {
                    var temp = matrix[row - 1][col];
                    matrix[row - 1][col] = matrix[row][col];
                    matrix[row][col] = temp;
                    row++;
                }
                else
                {
                    return;
                }
            }
        }

        private static bool IsCellShooted(int i, int j, int impactRow, int impactCol, int impactRadius)
        {
            var distance = Math.Sqrt((i - impactRow) * (i - impactRow) + (j - impactCol) * (j - impactCol));
            return distance <= impactRadius;
        }

        private static char[][] InitializeMAtrix()
        {
            var dimensions = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var matrix = new char[dimensions[0]][].Select(r => r = new char[dimensions[1]]).ToArray();

            var snake = new Queue<char>(Console.ReadLine().ToCharArray());

            // Spread the snake over the stairs
            for (int i = matrix.Length - 1; i >= 0; i--)
            {
                for (int j = matrix[i].Length - 1; j >= 0; j--)
                {
                    matrix[i][j] = snake.Dequeue();
                    snake.Enqueue(matrix[i][j]);
                }

                i--;

                if (i < 0)
                {
                    break;
                }

                for (int j = 0; j < matrix[i].Length; j++)
                {
                    matrix[i][j] = snake.Dequeue();
                    snake.Enqueue(matrix[i][j]);
                }
            }

            return matrix;
        }
    }
}
