using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            double max = double.Parse(Console.ReadLine());
            for (int i = 1; i < number; i++)
            {
                double d = double.Parse(Console.ReadLine());
                if (d > max) max = d;
            }
            Console.WriteLine(max);
        }
    }
}
