namespace _02.Jedi_Galaxy
{
    using System;
    using System.Linq;

    public class JediGalaxy
    {
        public static void Main()
        {
            var matrix = GetMatrix();
            var collectedStars = CollectStars(matrix);
            Console.WriteLine(collectedStars);
        }

        private static long CollectStars(int[][] matrix)
        {
            var collectedStars = 0L;
            var input = Console.ReadLine();

            while (input != "Let the Force be with you")
            {
                var ivoPosition = input.Split().Select(int.Parse).ToArray();
                var evilPosition = Console.ReadLine().Split().Select(int.Parse).ToArray();

                /*
                 * The given rows will be valid integers in the range [0, 2000].
                 * The given columns will be valid integers in the range [-231 + 1, 231 - 1].
                 */

                EvilMoove(matrix, evilPosition);
                collectedStars += IvoMoove(matrix, ivoPosition);

                input = Console.ReadLine();
            }

            return collectedStars;
        }

        private static long IvoMoove(int[][] matrix, int[] ivoPosition)
        {
            var stars = 0L;

            while (ivoPosition[0] >= 0 && ivoPosition[1] < matrix[0].Length)
            {
                if (IsInMatrix(matrix, ivoPosition))
                {
                    stars += matrix[ivoPosition[0]][ivoPosition[1]];
                }

                ivoPosition[0]--;
                ivoPosition[1]++;
            }

            return stars;
        }

        private static void EvilMoove(int[][] matrix, int[] evilPosition)
        {
            while (evilPosition[0] >= 0 && evilPosition[1] >= 0)
            {
                if (IsInMatrix(matrix, evilPosition))
                {
                    matrix[evilPosition[0]][evilPosition[1]] = 0;
                }

                evilPosition[0]--;
                evilPosition[1]--;
            }
        }

        private static bool IsInMatrix(int[][] matrix, int[] position)
        {
            return position[0] >= 0 && position[1] >= 0 && position[0] < matrix.Length && position[1] < matrix[position[0]].Length;
        }

        private static int[][] GetMatrix()
        {
            var dimensions = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var matrix = new int[dimensions[0]][];
            var cellValue = 0;

            for (int i = 0; i < matrix.Length; i++)
            {
                matrix[i] = new int[dimensions[1]];

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
