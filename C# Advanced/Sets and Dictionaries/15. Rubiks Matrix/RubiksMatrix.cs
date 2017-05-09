namespace _15.Rubiks_Matrix
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class RubiksMatrix
    {
        public static void Main()
        {
            // Set matrix
            var rowsColumns = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            if (rowsColumns.Length < 2)
            {
                return;
            }

            int[,] matrix = InitializeMatrix(rowsColumns[0], rowsColumns[1]);

            // Rotate Rubix's matrix
            RotateMatrix(matrix);

            // Rearrange rubiksMatrix to its initial state
            string output = SwapBackToInitialState(matrix);

            // Write swap actions on the console
            Console.Write(output);
        }

        private static string SwapBackToInitialState(int[,] matrix)
        {
            var swapActions = new StringBuilder(); // Here will build the Output
            var targetNumber = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    targetNumber++;

                    if (matrix[row, col] == targetNumber)
                    {
                        swapActions.Append($"No swap required{Environment.NewLine}");
                    }
                    else // Swap numbers
                    {
                        for (int exchangeRow = row; exchangeRow < matrix.GetLength(0); exchangeRow++)
                        {
                            for (int exchangeCol = 0; exchangeCol < matrix.GetLength(1); exchangeCol++)
                            {
                                if (matrix[exchangeRow, exchangeCol] == targetNumber)
                                {
                                    matrix[exchangeRow, exchangeCol] = matrix[row, col];
                                    matrix[row, col] = targetNumber;

                                    swapActions.Append($"Swap ({row}, {col}) with ({exchangeRow}, {exchangeCol}){Environment.NewLine}");
                                    exchangeRow = matrix.GetLength(0);
                                    exchangeCol = matrix.GetLength(1);
                                }
                            }
                        }
                    }
                }
            }

            return swapActions.ToString();
        }

        private static void RotateMatrix(int[,] matrix)
        {
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var command = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                if (command.Length == 3)
                {
                    ExecuteCommand(matrix, command);
                }
            }
        }

        private static void ExecuteCommand(int[,] matrix, string[] command)
        {
            // Command format: {row/col} {direction} {moves}
            var rowColToRotate = int.Parse(command[0]);
            var direction = command[1].ToLower();
            var moves = int.Parse(command[2]);

            switch (direction)
            {
                case "up":
                    moves %= matrix.GetLength(0);
                    if (moves == 0)
                    {
                        return;
                    }

                    if (moves < 0)
                    {
                        command[2] = string.Empty + Math.Abs(moves);
                        command[1] = "down";
                        ExecuteCommand(matrix, command);
                        return;
                    }

                    RotateColumn(matrix, moves, rowColToRotate);
                    break;
                case "down":
                    moves %= matrix.GetLength(0);
                    if (moves == 0)
                    {
                        return;
                    }

                    if (moves < 0)
                    {
                        command[2] = string.Empty + Math.Abs(moves);
                        command[1] = "up";
                        ExecuteCommand(matrix, command);
                        return;
                    }

                    RotateColumn(matrix, matrix.GetLength(0) - moves, rowColToRotate);
                    break;
                case "left":
                    moves %= matrix.GetLength(1);
                    if (moves == 0)
                    {
                        return;
                    }

                    if (moves < 0)
                    {
                        command[2] = string.Empty + Math.Abs(moves);
                        command[1] = "right";
                        ExecuteCommand(matrix, command);
                        return;
                    }

                    RotateRow(matrix, moves, rowColToRotate);
                    break;
                case "right":
                    moves %= matrix.GetLength(1);
                    if (moves == 0)
                    {
                        return;
                    }

                    if (moves < 0)
                    {
                        command[2] = string.Empty + Math.Abs(moves);
                        command[1] = "left";
                        ExecuteCommand(matrix, command);
                        return;
                    }

                    RotateRow(matrix, matrix.GetLength(1) - moves, rowColToRotate);
                    break;
                default:
                    break;
            }
        }

        private static void RotateRow(int[,] matrix, int colToStart, int rowToRotate)
        {
            var numberOfRows = matrix.GetLength(1);

            if (rowToRotate >= numberOfRows || rowToRotate < 0)
            {
                return;
            }

            var rotatedRow = new Queue<int>(numberOfRows);

            for (int i = 0; i < numberOfRows; i++)
            {
                colToStart %= numberOfRows;
                rotatedRow.Enqueue(matrix[rowToRotate, colToStart]);
                colToStart++;
            }

            for (int col = 0; col < numberOfRows; col++)
            {
                matrix[rowToRotate, col] = rotatedRow.Dequeue();
            }
        }

        private static void RotateColumn(int[,] matrix, int rowToStart, int columnToRotate)
        {
            var numberOfColumns = matrix.GetLength(0);

            if (columnToRotate >= numberOfColumns || columnToRotate < 0)
            {
                return;
            }

            var rotatedColumn = new Queue<int>(numberOfColumns);

            for (int i = 0; i < numberOfColumns; i++)
            {
                rowToStart %= numberOfColumns;
                rotatedColumn.Enqueue(matrix[rowToStart, columnToRotate]);
                rowToStart++;
            }

            for (int row = 0; row < numberOfColumns; row++)
            {
                matrix[row, columnToRotate] = rotatedColumn.Dequeue();
            }
        }

        private static int[,] InitializeMatrix(int rows, int columns)
        {
            var matrix = new int[rows, columns];
            var currentNumber = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    currentNumber++;
                    matrix[row, col] = currentNumber;
                }
            }

            return matrix;
        }
    }
}
