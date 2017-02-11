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
            Console.WriteLine("{0:F3}", Point.GetDistance(p1, p2));
        }

        public static Point SetPoint()
        {
            double[] input = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToArray();

            Point p = new Point(input[0], input[1]);

            return p;
        }

        public class Point
        {
            private double x, y;

            public Point()
            {
                this.x = 0;
                this.y = 0;
            }

            public Point(double x, double y)
            {
                this.x = x;
                this.y = y;
            }

            public static double GetDistance(Point p1, Point p2)
            {
                return Math.Sqrt(Math.Pow(p1.x - p2.x, 2) + Math.Pow(p1.y - p2.y, 2));
            }
        }
    }
}
