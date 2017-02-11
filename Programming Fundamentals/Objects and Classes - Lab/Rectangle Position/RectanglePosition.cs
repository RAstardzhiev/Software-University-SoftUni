namespace Rectangle_Position
{
    using System;
    using System.Linq;

    public class RectanglePosition
    {
        public static void Main(string[] args)
        {
            Rectangle r1 = ReadRectanglge();
            Rectangle r2 = ReadRectanglge();
            Console.WriteLine(IsInside(r1, r2) ? "Inside" : "Not inside");
        }

        public static Rectangle ReadRectanglge()
        {
            double[] input = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToArray();

            Rectangle result = new Rectangle(input[0], input[1], input[2], input[3]);
            return result;
        }

        public static Boolean IsInside(Rectangle r1, Rectangle r2)
        {
            return ((r1.Left <= r2.Left && r1.Right >= r2.Right && r1.Top >= r2.Top && r1.Bottom <= r2.Bottom) || (r1.Left >= r2.Left && r1.Right <= r2.Right && r1.Top <= r2.Top && r1.Bottom >= r2.Bottom)) ? true : false;
        }
    }
}
