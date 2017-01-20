using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleOfDollars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0, col = 0; i < n; i++)
            {
                Console.Write("$");
                for (int j = 0; j < col; j++)
                {
                    Console.Write(" $");
                }
                col++;
                Console.WriteLine();
            }
        }
    }
}
