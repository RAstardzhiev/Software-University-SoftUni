using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            int period =     int.Parse(Console.ReadLine());

            int treated = 0, untreated = 0, doctors = 7;

            for (int i = 1; i <= period; i++)
            {
                if (i % 3 == 0 && untreated > treated) doctors++;
                int patients =   int.Parse(Console.ReadLine());
                if (patients <= doctors) treated += patients;
                else
                {
                    treated += doctors;
                    untreated += patients - doctors;
                }
            }

            Console.WriteLine("Treated patients: {0}.", treated);
            Console.WriteLine("Untreated patients: {0}.", untreated);
        }
    }
}
