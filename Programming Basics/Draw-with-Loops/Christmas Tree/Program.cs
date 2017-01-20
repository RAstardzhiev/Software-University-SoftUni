using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Christmas_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.Write(new string(' ', n + 1));
            Console.WriteLine('|');

            for (int i = 1, s = n - 1; i <= n; i++, s--)
            {
                string space = new string(' ', s);
                String stars = new string('*', i);
                Console.WriteLine("{0}{1} | {1}", space, stars);
            }
        }
    }
}
