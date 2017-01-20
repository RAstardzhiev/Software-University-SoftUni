using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_in_Range__1._._._100_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Еnter a number in the range [1...100]: ");
            int n = int.Parse(Console.ReadLine());
            while (n < 1 || n > 100)
            {
                Console.WriteLine("Invalid number!");
                Console.Write("Еnter a number in the range [1...100]: ");
                n = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("The number is: {0}", n);
        }
    }
}
