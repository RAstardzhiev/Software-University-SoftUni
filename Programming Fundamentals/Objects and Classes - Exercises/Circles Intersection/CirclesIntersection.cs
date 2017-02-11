namespace Circles_Intersection
{
    using System;
    using System.Linq;

    public class CirclesIntersection
    {
        public static void Main(string[] args)
        {
            Circle c1 = GetInputAndSetCircle();
            Circle c2 = GetInputAndSetCircle();
            Console.WriteLine(c1.Intersect(c2) ? "Yes" : "No");
        }

        public static Circle GetInputAndSetCircle()
        {
            Circle result = new Circle();
            double[] input = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToArray();

            result.Center = new Point() { X = input[0], Y = input[1] };
            result.Radius = input[2];
            return result;
        }
    }
}
