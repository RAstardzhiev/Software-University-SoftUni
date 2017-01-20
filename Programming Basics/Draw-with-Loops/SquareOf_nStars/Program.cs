using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareOf_nStars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            if (n == 1) Console.WriteLine("*");
            else
            {
                for (int i = 0; i < n; i++)
                {
                    Console.Write("* ");
                    for (int h = 0; h < n - 2; h++)
                    {
                        Console.Write("* ");
                    }
                    Console.WriteLine("*");
                }

            }
        }
    }
}
