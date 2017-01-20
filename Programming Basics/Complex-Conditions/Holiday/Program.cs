using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Holiday
{
    class Program
    {
        static void Main(string[] args)
        {
            var money = double.Parse(Console.ReadLine());
            string when = Console.ReadLine().ToLower();

            string destination = "", type = "";
            double expence = 0.0;

            if (money <= 100)
            {
                destination = "Bulgaria";
                if (when.Equals("summer"))
                {
                    expence = money * 0.3;
                    type = "Camp";
                }
                else
                {
                    expence = money * 0.7;
                    type = "Hotel";
                }
            }
            else if (money <= 1000)
            {
                destination = "Balkans";
                if (when.Equals("summer"))
                {
                    expence = money * 0.4;
                    type = "Camp";
                }
                else
                {
                    expence = money * 0.8;
                    type = "Hotel";
                }
            }
            else
            {
                destination = "Europe";
                expence = money * 0.9;
                type = "Hotel";
            }

            Console.WriteLine("Somewhere in {0}", destination);
            Console.WriteLine("{0} - {1:f2}", type, expence);
        }
    }
}
