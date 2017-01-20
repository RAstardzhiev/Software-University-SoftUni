using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Even_Powers_of_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0, num = 1; i <= n; i += 2, num *= 4)
            {
                Console.WriteLine(num);
            }
        }
    }
}
