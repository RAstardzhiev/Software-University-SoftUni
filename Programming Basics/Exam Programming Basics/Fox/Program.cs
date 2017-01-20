using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fox
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0, middle = 2; i < n; i++, middle += 2)
            {
                Console.WriteLine("{0}\\{1}/{0}", new string('*', 1 + i), new string('-', 2 * n + 3 - 2 - middle));
            }

            for (int i = 0; i < n / 3; i++)
            {
                Console.WriteLine("|{0}\\{1}/{0}|", new string('*', n / 2 + i), new string('*', (2 * n + 3 - 4) - n / 2 * 2 - i * 2));
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}\\{1}/{0}", new string('-', 1 + i), new string('*', n * 2 - 1 - i * 2));
            }

        }
    }
}
