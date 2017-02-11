namespace Distance_between_Points
{
    using System;
    using System.Linq;

    public class DistanceBetweenPoints
    {
        public static void Main(string[] args)
        {
            Point p1 = SetPoint();
            Point p2 = SetPoint();
            Console.WriteLine("{0:F3}", GetDistance(p1, p2));
        }

        public static Point SetPoint()
        {
            double[] input = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToArray();

            Point p = new Point { X = input[0], Y = input[1] };

            return p;
        }

        public static double GetDistance(Point p1, Point p2)
        {
            return Math.Sqrt(Math.Pow(p1.X - p2.X, 2) + Math.Pow(p1.Y - p2.Y, 2));
        }
    }
}
