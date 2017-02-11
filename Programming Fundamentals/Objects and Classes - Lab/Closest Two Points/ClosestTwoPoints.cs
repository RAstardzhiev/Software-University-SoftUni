namespace Closest_Two_Points
{
    using System;
    using System.Linq;

    public class ClosestTwoPoints
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Point[] points = new Point[n];

            for (int i = 0; i < points.Length; i++)
            {
                double[] xy = Console.ReadLine()
                    .Split(' ')
                    .Select(double.Parse)
                    .ToArray();

                points[i] = new Point(xy[0], xy[1]);
            }

            PrintTheShortestTwoPoints(points);
        }

        public static void PrintTheShortestTwoPoints(Point[] points)
        {
            double minDistance = double.MaxValue;
            int[] minIndexes = new int[2];
            for (int i = 0; i < points.Length; i++)
            {
                for (int j = 0; j < points.Length; j++)
                {
                    if (i == j)
                    {
                        continue;
                    }

                    double distance = GetDistance(points[i], points[j]);
                    if (distance < minDistance)
                    {
                        minDistance = distance;
                        minIndexes[0] = i;
                        minIndexes[1] = j;
                    }
                }
            }

            Console.WriteLine($"{minDistance:F3}\n({points[minIndexes[0]].X}, {points[minIndexes[0]].Y})\n({points[minIndexes[1]].X}, {points[minIndexes[1]].Y})");
        }

        public static double GetDistance(Point p1, Point p2)
        {
            return Math.Sqrt(Math.Pow(p1.X - p2.X, 2) + Math.Pow(p1.Y - p2.Y, 2));
        }
    }
}
