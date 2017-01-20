using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greatest_Common_Divisor__CGD_
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            int gcd = 0;
            int separator = Math.Min(a, b), separated = Math.Max(a, b);

            while (true)
            {
                if (separated % separator == 0)
                {
                    gcd = separator;
                    break;
                }
                else
                {
                    int reminder = separated % separator;
                    separated = separator;
                    separator = reminder;
                }
            }

            Console.WriteLine(gcd);
        }
    }
}
