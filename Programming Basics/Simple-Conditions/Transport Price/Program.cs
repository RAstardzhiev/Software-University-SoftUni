using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transport_Price
{
    class Program
    {
        static void Main(string[] args)
        {
            var km = int.Parse(Console.ReadLine());
            string time = Console.ReadLine();

            // Expense
            if (km >= 100)
                Console.WriteLine(km * 0.06);
            else if (km >= 20)
                Console.WriteLine(km * 0.09);
            else
            {
                if (time.Equals("day"))
                    Console.WriteLine(0.70 + km * 0.79);
                else if (time.Equals("night"))
                    Console.WriteLine(0.70 + km * 0.90);
            }

        }
    }
}
