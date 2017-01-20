using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Min_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int l = int.Parse(Console.ReadLine());
            int min = int.Parse(Console.ReadLine());
            for (int i = 1; i < l; i++)
            {
                int n = int.Parse(Console.ReadLine());
                if (n < min) min = n;
            }
            Console.WriteLine(min);
        }
    }
}
