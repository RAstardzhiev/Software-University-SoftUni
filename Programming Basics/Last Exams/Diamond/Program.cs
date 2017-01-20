using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            int n =  int.Parse(Console.ReadLine());

            for (int i = 0, center = 0; i < n; i++, center += 2)
            {
                char middle = '?';
                if (i == 0) middle = '*';
                else middle = '.';
                Console.WriteLine("{0}*{1}*{0}", new string('.', n - i), new string(middle, 3 * n - 2 + center));
            }

            Console.WriteLine(new string('*', 5 * n));

            int lastMiddle = 0;

            for (int i = 1; i <= n * 2; i++)
            {
                Console.WriteLine("{0}*{1}*{0}", new string('.', i), new string('.', 5 * n - (2 + 2 * i)));
                lastMiddle = 5 * n - (4 + 2 * i);
            }

            Console.WriteLine("{0}*{1}*{0}", new string('.', 2 * n + 1), new string('*', lastMiddle));

        }
    }
}
