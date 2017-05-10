namespace _16.Target_Practice
{
    using System;
    using System.Linq;

    public class TargetPractice
    {
        public static void Main()
        {
            var stairs = InitializeStairsMatrix();

            // Fill the stairs matrix with snake symbols
            GetSnakeOnStairs(stairs);

            // Take a shot
            ShotAtSnake(stairs);

            // Preiint the resulting matrix
            PrintMatrix(stairs);
        }

        private static void PrintMatrix(char[][] matrix)
        {
            for (int row = 0; row < matrix.Length; row++)
            {
                Console.WriteLine(string.Join(string.Empty, matrix[row]));
            }
        }

        private static void ShotAtSnake(char[][] matrix)
        {
            var shot = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var impactRow = shot[0];
            var impactCol = shot[1];
            var impactRadius = shot[2];

            for (int row = matrix.Length - 1; row >= 0; row--)
            {
                for (int col = matrix[row].Length - 1; col >= 0; col--)
                {
                    if (IsCelInsideTheBlast(impactRow, impactCol, impactRadius, row, col))
                    {
                        matrix[row][col] = ' ';
                    }
                    else
                    {
                        FallDown(row, col, matrix);
                    }
                }
            }
        }

        private static void FallDown(int row, int col, char[][] matrix)
        {
            var isNeededSwap = false;
            var lastSpaceIndex = -1;

            for (int i = row + 1; i < matrix.Length; i++)
            {
                if (matrix[i][col] == ' ')
                {
                    isNeededSwap = true;
                    lastSpaceIndex = i;
                }
                else
                {
                    break;
                }
            }

            if (isNeededSwap)
            {
                matrix[lastSpaceIndex][col] = matrix[row][col];
                matrix[row][col] = ' ';
            }
        }

        private static bool IsCelInsideTheBlast(int impactRow, int impactCol, int impactRadius, int rowToCheck, int colToCheck)
        {
            var distance = Math.Sqrt((impactRow - rowToCheck) * (impactRow - rowToCheck) + (impactCol - colToCheck) * (impactCol - colToCheck));
            return distance <= impactRadius;
        }

        private static void GetSnakeOnStairs(char[][] matrix)
        {
            var snake = Console.ReadLine().Replace(" ", string.Empty);
            var snakeCharIndex = - 1;
            var startRowAt = 'R';

            for (int row = matrix.Length - 1; row >= 0; row--)
            {
                switch (startRowAt)
                {
                    case 'R': // Snake is climbing from right to left
                        for (int col = matrix[row].Length - 1; col >= 0; col--)
                        {
                            snakeCharIndex = (snakeCharIndex == snake.Length - 1) ? 0 : snakeCharIndex + 1;
                            matrix[row][col] = snake[snakeCharIndex];
                        }

                        startRowAt = 'L';
                        break;
                    case 'L': // Snake is climbing from left to right
                        for (int col = 0; col < matrix[row].Length; col++)
                        {
                            snakeCharIndex = (snakeCharIndex == snake.Length - 1) ? 0 : snakeCharIndex + 1;
                            matrix[row][col] = snake[snakeCharIndex];
                        }

                        startRowAt = 'R';
                        break;
                    default:
                        break;
                }
            }
        }

        private static char[][] InitializeStairsMatrix()
        {
            var rowsCols = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var matrix = new char[rowsCols[0]][];

            for (int i = 0; i < matrix.Length; i++)
            {
                matrix[i] = new char[rowsCols[1]];
            }

            return matrix;
        }
    }
}
