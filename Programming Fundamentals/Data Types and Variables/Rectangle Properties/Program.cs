using System;

namespace Rectangle_Properties
{
    public class Rectangle_Properties
    {
        public static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            // Rectangle Perimeter = 2 * (width + heigth)
            Console.WriteLine(2 * (width + height));
            // Rectangle Area = width * height
            Console.WriteLine(width * height);
            // Rectangle Diagonal = Math.sqrt(width * width + height * height)
            Console.WriteLine(Math.Sqrt(width * width + height * height));
        }
    }
}
