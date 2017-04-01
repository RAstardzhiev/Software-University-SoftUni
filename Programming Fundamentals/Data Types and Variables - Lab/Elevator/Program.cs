using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());
            Console.WriteLine(Math.Ceiling((double)n / capacity));
        }
    }
}
