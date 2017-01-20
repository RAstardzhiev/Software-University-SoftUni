using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nStars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                for (int ji = 0; ji < n; ji++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
