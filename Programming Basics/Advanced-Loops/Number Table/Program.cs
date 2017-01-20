using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int n =  int.Parse(Console.ReadLine());

            for (int row = 0; row < n; row++)
            {
                Boolean reached = false;
                for (int col = 0, write = row + 1; col < n; col++)
                {
                    Console.Write("{0} ", write);
                    if (write == n) reached = true;
                    if (reached) write--;
                    else write++;
                }
                Console.WriteLine();
            }
        }
    }
}
