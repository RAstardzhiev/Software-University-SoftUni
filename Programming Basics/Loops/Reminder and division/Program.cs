using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reminder_and_division
{
    class Program
    {
        static void Main(string[] args)
        {
            int digits = int.Parse(Console.ReadLine());

            double per2 = 0, per3 = 0, per4 = 0;

            for (int i = 0; i < digits; i++)
            {
                int n = int.Parse(Console.ReadLine());
                if (n % 2 == 0) per2++;
                if (n % 3 == 0) per3++;
                if (n % 4 == 0) per4++;
            }

            Console.WriteLine("{0:0.00}%", Math.Round(per2 / digits * 100, 2));
            Console.WriteLine("{0:0.00}%", Math.Round(per3 / digits * 100, 2));
            Console.WriteLine("{0:0.00}%", Math.Round(per4 / digits * 100, 2));
        }
    }
}
