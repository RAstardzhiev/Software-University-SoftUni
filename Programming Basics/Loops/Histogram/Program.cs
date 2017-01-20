using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int digits = int.Parse(Console.ReadLine());

            double upTo_199 = 0, _200_399 = 0, _400_599 = 0, _600_799 = 0, GreaterThan_800 = 0;
            //            Console.WriteLine("{0: 0.00}%", Math.Round(5.347, 2));
            for (int i = 0; i < digits; i++)
            {
                double n = int.Parse(Console.ReadLine());
                if (n < 200) upTo_199++;
                else if (n < 400) _200_399++;
                else if (n < 600) _400_599++;
                else if (n < 800) _600_799++;
                else GreaterThan_800++;
            }
            Console.WriteLine((upTo_199 / digits).ToString("0.00%"));
            Console.WriteLine((_200_399 / digits).ToString("0.00%"));
            Console.WriteLine((_400_599 / digits).ToString("0.00%"));
            Console.WriteLine((_600_799 / digits).ToString("0.00%"));
            Console.WriteLine((GreaterThan_800 / digits).ToString("0.00%"));
        }
    }
}
