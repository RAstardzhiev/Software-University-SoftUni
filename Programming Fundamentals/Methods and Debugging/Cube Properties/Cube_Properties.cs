namespace Cube_Properties
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Cube_Properties
    {
        public static void Main(string[] args)
        {
            // On the first line you will get the side of the cube
            // On the second line is given the parameter (face, space, volume or area)
            double side = double.Parse(Console.ReadLine());
            string parameter = Console.ReadLine().ToLower();

            switch (parameter)
            {
                case "face": CubeFaceDiagonals(side);
                    break;
                case "space": CubeSpaceDiagonals(side);
                    break;
                case "volume": CubeVolume(side);
                    break;
                case "area": CubeSurfaceArea(side);
                    break;
                default:
                    break;
            }
        }

        public static void CubeFaceDiagonals(double side)
        {
            Console.WriteLine("{0:f2}", Math.Sqrt(2 * (side * side)));
        }

        public static void CubeSpaceDiagonals(double side)
        {
            Console.WriteLine("{0:f2}", Math.Sqrt(3 * (side * side)));
        }

        public static void CubeVolume(double side)
        {
            Console.WriteLine("{0:f2}", side * side * side);
        }

        public static void CubeSurfaceArea(double side)
        {
            Console.WriteLine("{0:f2}", 6 * (side * side));
        }
    }
}
