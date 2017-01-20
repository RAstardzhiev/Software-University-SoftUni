using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_100._._._200
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            if (n < 100)
                Console.WriteLine("Less than 100");
            else if (n < 201)
                Console.WriteLine("Between 100 and 200");
            else
                Console.WriteLine("Greater than 200");
        }
    }
}
