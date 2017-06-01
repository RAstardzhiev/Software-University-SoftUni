namespace _12.String_Matrix_Rotation
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class StringMatrixRotation
    {
        public static void Main()
        {
            var rotateDegrees = GetDegrees();

            if (rotateDegrees == 0 || rotateDegrees == 90) // Use List<Queue<char>>
            {
                int maxCount;
                var matrix = InitializeQueueMatrix(out maxCount);
                PrintMatrix(matrix, rotateDegrees, maxCount);
            }
            else if (rotateDegrees == 180 || rotateDegrees == 270) // Use List<Stack<char>>
            {
                int maxCount;
                var matrix = InitializeStackMatrix(out maxCount);
                PrintMatrix(matrix, rotateDegrees, maxCount);
            }
            else
            {
                throw new Exception("Wrong input. Degrees must be multiple of 90°!!!");
            }
        }

        private static void PrintMatrix(List<Stack<char>> matrix, int rotateDegrees, int maxCount)
        {
            var sb = new StringBuilder();

            if (rotateDegrees == 180)
            {
                for (int i = matrix.Count - 1; i >= 0; i--)
                {
                    sb.Append(string.Join(string.Empty, matrix[i]));

                    if (matrix[i].Count < maxCount)
                    {
                        sb.Append(new string(' ', maxCount - matrix[i].Count));
                    }

                    sb.Append(Environment.NewLine);
                }
            }
            else if (rotateDegrees == 270)
            {
                while (maxCount > 0)
                {
                    for (int i = 0; i < matrix.Count; i++)
                    {
                        if (matrix[i].Count > 0 && matrix[i].Count == maxCount)
                        {
                            sb.Append(matrix[i].Pop());
                        }
                        else
                        {
                            sb.Append(' ');
                        }
                    }

                    sb.Append(Environment.NewLine);
                    maxCount--;
                }
            }

            Console.Write(sb.ToString());
        }

        private static void PrintMatrix(List<Queue<char>> matrix, int rotateDegrees, int maxCount)
        {
            var sb = new StringBuilder();

            if (rotateDegrees == 0)
            {
                for (int i = 0; i < matrix.Count; i++)
                {
                    sb.Append(string.Join(string.Empty, matrix[i]));

                    if (matrix[i].Count < maxCount)
                    {
                        sb.Append(new string(' ', maxCount - matrix[i].Count));
                    }

                    sb.Append(Environment.NewLine);
                }
            }
            else if (rotateDegrees == 90)
            {
                while (maxCount > 0)
                {
                    for (int i = matrix.Count - 1; i >= 0; i--)
                    {
                        if (matrix[i].Count > 0)
                        {
                            sb.Append(matrix[i].Dequeue());
                        }
                        else
                        {
                            sb.Append(' ');
                        }
                    }

                    sb.Append(Environment.NewLine);
                    maxCount--;
                }
            }

            Console.Write(sb.ToString());
        }

        private static List<Stack<char>> InitializeStackMatrix(out int maxCount)
        {
            maxCount = 0;
            var matrix = new List<Stack<char>>();
            var input = Console.ReadLine();

            while (input != "END")
            {
                maxCount = Math.Max(maxCount, input.Length);
                matrix.Add(new Stack<char>(input.ToCharArray()));
                input = Console.ReadLine();
            }

            return matrix;
        }

        private static List<Queue<char>> InitializeQueueMatrix(out int maxCount)
        {
            maxCount = 0;
            var matrix = new List<Queue<char>>();
            var input = Console.ReadLine();

            while (input != "END")
            {
                maxCount = Math.Max(maxCount, input.Length);
                matrix.Add(new Queue<char>(input.ToCharArray()));
                input = Console.ReadLine();
            }

            return matrix;
        }

        private static int GetDegrees()
        {
            var input = Console.ReadLine();
            input = input.Remove(0, input.IndexOf('(') + 1);
            return int.Parse(input.Substring(0, input.IndexOf(')'))) % 360;
        }
    }
}
