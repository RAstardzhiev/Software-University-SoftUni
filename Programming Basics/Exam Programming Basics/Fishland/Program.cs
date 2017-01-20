using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fishland
{
    class Program
    {
        static void Main(string[] args)
        {
            double skumriqPrice = double.Parse(Console.ReadLine());
            double cacaPrice = double.Parse(Console.ReadLine());
            double palamudKG = double.Parse(Console.ReadLine());
            double safridKG = double.Parse(Console.ReadLine());
            int midiKG = int.Parse(Console.ReadLine());

            double palamudExpence = palamudKG * (skumriqPrice * 1.60);
            double midiExpence = midiKG * 7.50;
            double safridExpence = safridKG * (cacaPrice * 1.80);

            Console.WriteLine("{0:0.00}", palamudExpence + midiExpence + safridExpence);
        }
    }
}
