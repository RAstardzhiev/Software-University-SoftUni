namespace Geometry_Calculator
{
    using System;

    public class Geometry_Calculator
    {
        public static void Main(string[] args)
        {
            // Calculate the area of four different geometry figures - triangle, square, rectangle and circle
            string figure = Console.ReadLine();
            PrintArea(figure);
        }

        private static void PrintArea(string figure)
        {
            switch (figure.ToLower())
            {
                case "triangle": TriangleArea();
                    break;
                case "square": SquareArea();
                    break;
                case "rectangle": RectangleArea();
                    break;
                case "circle": CircleArea();
                    break;
                default:
                    break;
            }
        }

        private static void CircleArea()
        {
            // Circle -> Input: radius
            double radius = double.Parse(Console.ReadLine());
            Console.WriteLine("{0:F2}", Math.PI * (radius * radius));
        }

        private static void RectangleArea()
        {
            // Rectangle -> Input: width and height
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            Console.WriteLine("{0:F2}", width * height);
        }

        private static void SquareArea()
        {
            // Square -> Input: side
            double side = double.Parse(Console.ReadLine());
            Console.WriteLine("{0:F2}", side * side);
        }

        private static void TriangleArea()
        {
            // Triangle -> Input: side and height
            double side = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            Console.WriteLine("{0:F2}", (side * height) / 2);
        }
    }
}
