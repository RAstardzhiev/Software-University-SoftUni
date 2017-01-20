using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trade_Comissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine().ToLower();
            var amount = double.Parse(Console.ReadLine());

            if (amount <= 0) Console.WriteLine("error");
            else if (town.Equals("sofia"))
            {
                if (amount <= 500) Console.WriteLine("{0:0.00}", amount * 0.05, 2);
                else if (amount <= 1000) Console.WriteLine("{0:0.00}", amount * 0.07);
                else if (amount <= 10000) Console.WriteLine("{0:0.00}", amount * 0.08);
                else Console.WriteLine("{0:0.00}", amount * 0.12);
            }
            else if (town.Equals("varna"))
            {
                if (amount <= 500) Console.WriteLine("{0:0.00}", amount * 0.045);
                else if (amount <= 1000) Console.WriteLine("{0:0.00}", amount * 0.075);
                else if (amount <= 10000) Console.WriteLine("{0:0.00}", amount * 0.10);
                else Console.WriteLine("{0:0.00}", amount * 0.13);
            }
            else if (town.Equals("plovdiv"))
            {
                if (amount <= 500) Console.WriteLine("{0:0.00}", amount * 0.055);
                else if (amount <= 1000) Console.WriteLine("{0:0.00}", amount * 0.08);
                else if (amount <= 10000) Console.WriteLine("{0:0.00}", amount * 0.12);
                else Console.WriteLine("{0:0.00}", amount * 0.145);
            }
            else Console.WriteLine("error");
        }
    }
}
