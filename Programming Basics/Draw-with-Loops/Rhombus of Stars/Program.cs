using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rhombus_of_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            // Upper
            for (int i = 0; i < n; i++)
            {
                Console.Write(new string(' ', n - (i + 1)));
                Console.Write("*");
                for (int j = 0; j <= i - 1; j++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }

            // Down
            for (int i = 1; i < n; i++)
            {
                Console.Write(new string(' ', i - 1));
                //Console.Write("*");
                for (int j = 0; j < n - i; j++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }
        }
    }
}
