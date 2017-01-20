using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int n =  int.Parse(Console.ReadLine());
            int fact = n;

            for (int i = n - 1; i > 0; i--)
            {
                fact *= i;
            }

            Console.WriteLine(fact);
        }
    }
}
