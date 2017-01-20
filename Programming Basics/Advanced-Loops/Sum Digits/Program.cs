using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;

            while (true)
            {
                sum += n % 10;
                if (n < 10)
                    break;
                n /= 10;
            }

            Console.WriteLine(sum);
        }
    }
}
