using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money
{
    class Program
    {
        static void Main(string[] args)
        {
            int bitCoins =   int.Parse(Console.ReadLine());
            double chineseYona =     double.Parse(Console.ReadLine());
            double comission =   double.Parse(Console.ReadLine());

            //•	1 биткойн = 1168 лева.
            //•	1 китайски юан = 0.15 долара.
            //•	1 долар = 1.76 лева.
            //•	1 евро = 1.95 лева.

            double eur = (bitCoins * 1168 + chineseYona * 0.15 * 1.76) / 1.95;
            double fee = comission / 100 * eur;
            Console.WriteLine(eur - fee);
        }
    }
}
