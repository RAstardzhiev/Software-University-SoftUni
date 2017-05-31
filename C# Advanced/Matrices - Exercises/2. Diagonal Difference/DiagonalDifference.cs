namespace _2.Diagonal_Difference
{
    using System;
    using System.Linq;

    public class DiagonalDifference
    {
        public static void Main()
        {
            var matrix = InitializeMatrix();
            var primaryDiagonal = SumDiagonal(matrix, "primary");
            var secondaryDiagonal = SumDiagonal(matrix, "secondary");
            Console.WriteLine(Math.Abs(primaryDiagonal - secondaryDiagonal));
        }

        private static int SumDiagonal(int[][] matrix, string diagonal)
        {
            var diagonalSetter = (diagonal.ToLower().Equals("secondary")) ? matrix[0].Length - 1 : 0;
            var sum = 0;

            for (int i = 0; i < matrix.Length; i++)
            {
                sum += matrix[i][Math.Abs(diagonalSetter - i)];
            }

            return sum;
        }

        private static int[][] InitializeMatrix()
        {
            var dimensions = int.Parse(Console.ReadLine());

            var matrix = new int[dimensions][];

            for (int i = 0; i < matrix.Length; i++)
            {
                matrix[i] = Console.ReadLine().Split().Take(dimensions).Select(int.Parse).ToArray();
            }

            return matrix;
        }
    }
}
