namespace Calculate_Triangle_Area
{
    using System;

    public class CalculateTriangleArea
    {
        public static void Main(string[] args)
        {
            double baseLength = double.Parse(Console.ReadLine());
            double haightLength = double.Parse(Console.ReadLine());
            Console.WriteLine(TriangleArea(baseLength, haightLength));
        }

        private static double TriangleArea(double baseLength, double haightLength)
        {
            return baseLength * haightLength / 2;
        }
    }
}
