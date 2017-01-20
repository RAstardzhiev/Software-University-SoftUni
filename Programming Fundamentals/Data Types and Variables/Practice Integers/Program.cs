using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Types_and_Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            short n1 = -100;
            byte n2 = 128;
            short n3 = -3540;
            ushort n4 = 64876;
            uint n5 = 2147483648;
            int n6 = -1141583228;
            long n7 = -1223372036854775808;

            Console.WriteLine($"{n1}\n{n2}\n{n3}\n{n4}\n{n5}\n{n6}\n{n7}\n");
        }
    }
}