using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axe
{
    class Program
    {
        static void Main(string[] args)
        {
            int n =  int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}*{1}*{2}", new string('-', 3 * n), new string('-', i), new string('-', n * 2 - (2 + i)));
            }
            for (int i = 0; i < n / 2; i++)
            {
                Console.WriteLine("{0}*{1}*{1}", new string('*', n * 3), new string('-', n - 1));
            }
            for (int i = 0, middle = n - 1; i < n / 2; i++, middle += 2)
            {
                char centerLastRow = '?';
                if (i == n / 2 - 1) centerLastRow = '*';
                else centerLastRow = '-';
                Console.WriteLine("{0}*{1}*{2}", new string('-', 3 * n - i), new string(centerLastRow, middle), new string('-', n - 1 - i));
            }
        }
    }
}
