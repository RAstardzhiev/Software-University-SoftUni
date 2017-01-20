using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compare_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();
            Console.WriteLine((s1.ToLower().Equals(s2.ToLower())) ? "yes" : "no");
        }
    }
}
