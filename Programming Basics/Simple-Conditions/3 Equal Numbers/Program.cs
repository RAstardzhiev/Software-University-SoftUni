using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Equal_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var n1 = double.Parse(Console.ReadLine());
            var n2 = double.Parse(Console.ReadLine());
            var n3 = double.Parse(Console.ReadLine());
            Console.WriteLine(n1 == n2 && n2 == n3 ? "yes" : "no");
        }
    }
}
