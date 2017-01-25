namespace Center_Point
{
    using System;

    public class Center_Point
    {
        public static void Main(string[] args)
        {
            double p1x = double.Parse(Console.ReadLine());
            double p1y = double.Parse(Console.ReadLine());
            double p2x = double.Parse(Console.ReadLine());
            double p2y = double.Parse(Console.ReadLine());
            CenterCloserPoint(p1x, p1y, p2x, p2y);
        }

        public static void CenterCloserPoint(double p1x, double p1y, double p2x, double p2y)
        {
            double firstPointDistance = Math.Sqrt((p1x * p1x) + (p1y * p1y));
            double seconndPointDistance = Math.Sqrt((p2x * p2x) + (p2y * p2y));
            Console.WriteLine((firstPointDistance > seconndPointDistance) ? $"({p2x}, {p2y})" : $"({p1x}, {p1y})");
        }
    }
}
