using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_of_Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            String type = Console.ReadLine();
            if (type.Equals("square"))
                Console.WriteLine(squareArea());
            else if (type.Equals("rectangle"))
                Console.WriteLine(rectangleArea());
            else if (type.Equals("circle"))
                Console.WriteLine(circleArea());
            else if (type.Equals("triangle"))
                Console.WriteLine(triangleArea());
        }
        public static double triangleArea()
        {
            double sBase = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            return Math.Round((h * sBase) / 2, 3);
        }
        public static double circleArea()
        {
            double r = double.Parse(Console.ReadLine());
            return Math.Round(Math.PI * r * r, 3);
        }
        public static double rectangleArea()
        {
            double s1 = double.Parse(Console.ReadLine());
            double s2 = double.Parse(Console.ReadLine());
            return Math.Round(s1 * s2, 3);
        }
        public static double squareArea()
        {
            double s = double.Parse(Console.ReadLine());
            return Math.Round(s * s, 3);
        }
    }
}
