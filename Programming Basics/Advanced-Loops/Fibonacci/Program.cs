using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int n =  int.Parse(Console.ReadLine());

            if (n <= 1) Console.WriteLine("1");
            else
            {
                int f0 = 1, f1 = 1;
                for (int i = 1; i < n; i++)
                {
                    int temp = f1;
                    f1 += f0;
                    f0 = temp;
                }
                Console.WriteLine(f1);
            }
        }
    }
}
