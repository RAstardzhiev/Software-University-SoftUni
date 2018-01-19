namespace _07.Distance_in_Labyrinth
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Startup
    {
        private const char ForbiddenCellValue = 'x';
        private const char InputFreeCellValue = '0';
        private const char FreeCellValue = 'u';
        private const char PositionValue = '*';
        private const char FirstStepValue = '1';

        private static int[] PositionCell;

        public static void Main()
        {
            var matrix = GetMatrix();
            Console.WriteLine();
            NummerateSteps(PositionCell, FirstStepValue, matrix);
            PringMatrix(matrix);
        }

        private static void PringMatrix(char[][] matrix)
        {
            var sb = new StringBuilder();

            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    var currentValue = !char.IsDigit(matrix[i][j]) &&
                        matrix[i][j] != ForbiddenCellValue &&
                        matrix[i][j] != FreeCellValue &&
                        matrix[i][j] != PositionValue
                            ? (9 + (matrix[i][j] - '9')).ToString()
                            : matrix[i][j].ToString();

                    sb.Append(currentValue);
                }

                sb.AppendLine();
            }

            Console.WriteLine(sb.ToString().TrimEnd());
        }

        private static void NummerateSteps(int[] position, char cellValue, char[][] matrix)
        {
            var cells = new Queue<Cell>();
            cells.Enqueue(new Cell
            {
                Row = position[0],
                Col = position[1],
                NeighborValue = cellValue
            });

            while (cells.Count > 0)
            {
                var currentCell = cells.Dequeue();

                // Up 
                var isUpStepPossible = TrySetStepNumber(currentCell.Row - 1, currentCell.Col, currentCell.NeighborValue, matrix);
                if (isUpStepPossible)
                {
                    cells.Enqueue(new Cell
                    {
                        Row = currentCell.Row - 1,
                        Col = currentCell.Col,
                        NeighborValue = (char)(currentCell.NeighborValue + 1)
                    });
                }

                // Right
                var isRightStepPossible = TrySetStepNumber(currentCell.Row, currentCell.Col + 1, currentCell.NeighborValue, matrix);
                if (isRightStepPossible)
                {
                    cells.Enqueue(new Cell
                    {
                        Row = currentCell.Row,
                        Col = currentCell.Col + 1,
                        NeighborValue = (char)(currentCell.NeighborValue + 1)
                    });
                }

                // Down
                var isDownStepPossible = TrySetStepNumber(currentCell.Row + 1, currentCell.Col, currentCell.NeighborValue, matrix);
                if (isDownStepPossible)
                {
                    cells.Enqueue(new Cell
                    {
                        Row = currentCell.Row + 1,
                        Col = currentCell.Col,
                        NeighborValue = (char)(currentCell.NeighborValue + 1)
                    });
                }

                // Left
                var isLeftStepPossible = TrySetStepNumber(currentCell.Row, currentCell.Col - 1, currentCell.NeighborValue, matrix);
                if (isLeftStepPossible)
                {
                    cells.Enqueue(new Cell
                    {
                        Row = currentCell.Row,
                        Col = currentCell.Col - 1,
                        NeighborValue = (char)(currentCell.NeighborValue + 1)
                    });
                }
            }
        }

        private static bool TrySetStepNumber(int row, int col, char value, char[][] matrix)
        {
            if (IsInMatrix(row, col, matrix) && IsFreeCell(row, col, matrix))
            {
                matrix[row][col] = value;
                return true;
            }

            return false;
        }

        private static bool IsFreeCell(int row, int col, char[][] matrix)
            => matrix[row][col] == FreeCellValue;

        private static bool IsInMatrix(int row, int col, char[][] matrix)
            => row >= 0 && row < matrix.Length && col >= 0 && col < matrix[row].Length;

        private static char[][] GetMatrix()
        {
            var size = int.Parse(Console.ReadLine());
            var initialPosition = new int[2];

            var matrix = new char[size][];
            for (int i = 0; i < matrix.Length; i++)
            {
                var row = Console.ReadLine().Replace(InputFreeCellValue, FreeCellValue);
                var indexOfPosition = row.IndexOf(PositionValue);
                if (indexOfPosition >= 0)
                {
                    PositionCell = new int[] { i, indexOfPosition };
                }

                matrix[i] = row
                    .ToCharArray()
                    .Take(size)
                    .ToArray();
            }

            return matrix;
        }
    }
}

