using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int n =  int.Parse(Console.ReadLine());

            for (int i = 1, row = 1; i <= n; row++)
            {
                for (int j = 0; j < row && i <= n; j++, i++)
                {
                    Console.Write("{0} ", i);
                }
                Console.WriteLine();
            }
        }
    }
}
