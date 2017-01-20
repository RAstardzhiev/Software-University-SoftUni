using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odd_Even_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int digits = int.Parse(Console.ReadLine());
            int sum1 = 0, sum2 = 0;

            for (int i = 1; i <= digits; i++)
            {
                int n = int.Parse(Console.ReadLine());
                if (i % 2 == 0) sum2 += n;
                else sum1 += n;
            }

            if (sum1 == sum2)
                Console.WriteLine("Yes Sum = {0}", sum2);
            else Console.WriteLine("No Diff = {0}", Math.Abs(sum1 - sum2));
        }
    }
}
