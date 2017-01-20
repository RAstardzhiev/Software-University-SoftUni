using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Six_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(456 / 100);
            int num =  int.Parse(Console.ReadLine());
            int n = num;

            int rows = n / 100 + n / 10 % 10;
            int columns = n / 100 + n % 10;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (n % 5 == 0) n -= num / 100;
                    else if (n % 3 == 0) n -= num / 10 % 10;
                    else n += num % 10;
                    Console.Write("{0} ", n);
                }
                Console.WriteLine();
            }

        }
    }
}
