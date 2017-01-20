using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pipes_in_pool
{
    class Program
    {
        static void Main(string[] args)
        {
            var poolVolume = int.Parse(Console.ReadLine());
            var pipe1 = int.Parse(Console.ReadLine());
            var pipe2 = int.Parse(Console.ReadLine());
            var hours = double.Parse(Console.ReadLine());

            double p1Filled = pipe1 * hours;
            double p2Filled = pipe2 * hours;
            double allWater = p1Filled + p2Filled;

            if (allWater > poolVolume)
                Console.WriteLine("For {0} hours the pool overflows with {1} liters.", hours, allWater - poolVolume);
            else
            {
                // Всички проценти се свеждат до цяло число (без закръгляне).
                // The pool is [x]% full.Pipe 1: [y]%. Pipe 2: [z]%.
                int persentagePool = (int)(allWater / poolVolume * 100);
                int percentageP1 = (int)(p1Filled / allWater * 100);
                int percentageP2 = (int)(p2Filled / allWater * 100);
                Console.WriteLine("The pool is {0}% full. Pipe 1: {1}%. Pipe 2: {2}%.", persentagePool, percentageP1, percentageP2);
            }
        }
    }
}
