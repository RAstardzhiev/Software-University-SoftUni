using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equal_Pairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int pairs = int.Parse(Console.ReadLine());

            int sum1 = 0, sum2 = 0, dif = 0;

            for (int i = 1; i <= pairs; i++)
            {
                int n1 = int.Parse(Console.ReadLine());
                int n2 = int.Parse(Console.ReadLine());
                if (i % 2 == 0) sum2 = n1 + n2;
                else sum1 = n1 + n2;
                if (i > 1 && Math.Abs(sum1 - sum2) > dif)
                    dif = Math.Abs(sum2 - sum1);
            }
            if (dif == 0) Console.WriteLine("Yes, value={0}", sum1);
            else Console.WriteLine("No, maxdiff={0}", dif);
        }
    }
}
