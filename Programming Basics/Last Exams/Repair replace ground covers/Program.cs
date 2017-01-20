using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repair_replace_ground_covers
{
    class Program
    {
        static void Main(string[] args)
        {
            // Площадката е с форма на квадрат 
            //    •	n – дължината на страна от площадката в интервала [1...100]
            int n = int.Parse(Console.ReadLine());
            //    •	W – широчината на една плочка в интервала[0.1...10.00]
            //    •	L – дължината на една плочка в интервала[0.1...10.00]
            double w =   double.Parse(Console.ReadLine());
            double l =   double.Parse(Console.ReadLine());
            //    •	М – широчината на пейката в интервала[0...10]
            //    •	О – дължината на пейката в интервала[0...10]
            int m =  int.Parse(Console.ReadLine());
            int o =  int.Parse(Console.ReadLine());

            double workingArea = n * n - m * o;

            double plateArea = w * l;

            // Number of plates = workingArea / plateArea
            // Time = workingArea / plateArea * 0.2
            Console.WriteLine("{0}\n{1}", workingArea / plateArea, workingArea / plateArea * 0.2);

        }
    }
}
