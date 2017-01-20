using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Butterfly
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char ch = '?';

            // Upper Cut
            for (int i = 1; i <= 2 * (n - 2) / 2; i++)
            {
                if (i % 2 != 0) ch = '*';
                else ch = '-';
                Console.WriteLine("{0}\\ /{0}", new string(ch, n - 2));
            }
            Console.WriteLine("{0}@", new string(' ', n - 1));
            // Down Cut
            for (int i = 1; i <= 2 * (n - 2) / 2; i++)
            {
                if (i % 2 != 0) ch = '*';
                else ch = '-';
                Console.WriteLine("{0}/ \\{0}", new string(ch, n - 2));
            }
        }
    }
}
