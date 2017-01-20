using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int leftRight = (n - 1) / 2;
            int mid = n - 2 * leftRight - 2;
            int sent = 0;

            Console.Write(new string('-', leftRight));
            if (mid < 0) sent = 1;
            else sent = 2;
            Console.Write(new string('*', sent));
            Console.WriteLine(new string('-', leftRight));
            int j = sent;

            for (int i = leftRight; i > 0; i--, j += 2)
            {
                Console.Write(new string('-', i - 1));
                Console.Write('*');
                Console.Write(new string('-', j));
                Console.Write('*');
                Console.WriteLine(new string('-', i - 1));
            }

            j -= 4;

            for (int i = 1; j >= sent; i++, j -= 2)
            {
                Console.Write(new string('-', i));
                Console.Write('*');
                Console.Write(new string('-', j));
                Console.Write('*');
                Console.WriteLine(new string('-', i));
            }

            if (n > 2)
            {
                Console.Write(new string('-', leftRight));
                Console.Write(new string('*', sent));
                Console.WriteLine(new string('-', leftRight));
            }
        }
    }
}
