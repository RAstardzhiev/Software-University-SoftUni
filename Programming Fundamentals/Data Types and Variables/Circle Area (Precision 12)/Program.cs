using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle_Area__Precision_12_
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius = double.Parse(Console.ReadLine());
            Console.WriteLine("{0:F12}", Math.PI * radius * radius);
        }
    }
}