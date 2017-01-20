using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harvest___Rekolta
{
    class Program
    {
        static void Main(string[] args)
        {
            //•	1ви ред: X кв.м е лозето – цяло число в интервала[10 … 5000];
            int x =  int.Parse(Console.ReadLine());
            //•	2ри ред: Y грозде за един кв.м – реално число в интервала[0.00 … 10.00];
            double y =   double.Parse(Console.ReadLine());
            //•	3ти ред: Z нужни литри вино – цяло число в интервала[10 … 600];
            int z =  int.Parse(Console.ReadLine());
            //•	4ти ред: брой работници – цяло число в интервала[1 … 20];
            int n =  int.Parse(Console.ReadLine());

            double wine = x * y * 0.4 / 2.5;

            if (wine < z)
                Console.WriteLine("It will be a tough winter! More {0} liters wine needed.", (int)(z - wine));
            else
            {
                Console.WriteLine("Good harvest this year! Total wine: {0} liters.", (int)wine);
                Console.WriteLine("{0} liters left -> {1} liters per person.", Math.Ceiling(wine - z), Math.Ceiling((wine - z) / n));
            }
        }
    }
}
