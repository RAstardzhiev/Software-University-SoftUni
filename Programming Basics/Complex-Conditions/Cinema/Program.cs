using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine().ToLower();
            var rows = int.Parse(Console.ReadLine());
            var columns = int.Parse(Console.ReadLine());

            if (type.Equals("premiere")) Console.WriteLine("{0:f2} leva", rows * columns * 12);
            else if (type.Equals("normal")) Console.WriteLine("{0:f2} leva", rows * columns * 7.50);
            else if (type.Equals("discount")) Console.WriteLine("{0:f2} leva", rows * columns * 5);
        }
    }
}
