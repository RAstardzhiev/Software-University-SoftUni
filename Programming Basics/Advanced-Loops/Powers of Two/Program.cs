using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Powers_of_Two
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0, num = 1; i <= n; i++, num *= 2)
            {
                Console.WriteLine(num);
            }
        }
    }
}
