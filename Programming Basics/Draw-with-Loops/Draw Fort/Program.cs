using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draw_Fort
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            // Start
            // ^ = n / 2;
            Console.WriteLine("/{0}\\{1}/{0}\\", new string('^', n / 2), new string('_', (n - (n / 2 + 2)) * 2));

            // Middle 
            for (int i = 0; i < n - 2; i++)
            {
                if (i == n - 3)
                    Console.WriteLine("|{0}{1}{0}|", new string(' ', n / 2 + 1), new string('_', (n - (n / 2 + 2)) * 2));
                else
                    Console.WriteLine("|{0}|", new string(' ', n * 2 - 2));
            }

            // End
            Console.WriteLine("\\{0}/{1}\\{0}/", new string('_', n / 2), new string(' ', (n - (n / 2 + 2)) * 2));
        }
    }
}
