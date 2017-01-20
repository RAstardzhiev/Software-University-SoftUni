using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point_in_the_Figure
{
    class Program
    {
        static void Main(string[] args)
        {
            var squareSize = int.Parse(Console.ReadLine());
            var x = int.Parse(Console.ReadLine());
            var y = int.Parse(Console.ReadLine());

            //// Rectangle 1: 
            //    x1 = 0
            //    y1 = 0;
            //    x2 = squareSize * 3;
            //    y2 = squareSize;
            //// Rectangle 2: 
            //    x3 = squareSize;
            //    y3 = 0;
            //    x4 = squareSize * 2;
            //    y4 = 4 * squareSize;
            if (x > 0 && y > 0 && x < squareSize * 3 && y < squareSize || x > squareSize && y > 0 && x < squareSize * 2 && y < 4 * squareSize)
                Console.WriteLine("inside");
            else if (x < 0 || y < 0 || x > squareSize * 3 || y > squareSize && x < squareSize || y > squareSize && x > squareSize * 2 || y > 4 * squareSize)
                Console.WriteLine("outside");
            else Console.WriteLine("border");
        }
    }
}
