namespace Circles_Intersection
{
    using System;

    public class Point
    {
        public double X { get; set; }

        public double Y { get; set; }

        public double Distance(Point point)
        {
            return Math.Sqrt(Math.Pow(this.X - point.X, 2) + Math.Pow(point.Y - this.Y, 2));
        }
    }
}
