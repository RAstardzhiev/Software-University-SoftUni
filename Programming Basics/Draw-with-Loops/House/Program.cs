using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int RoofRows = (n + 1) / 2;
            string minusSpace = "";

            // Roof
            for (int i = 0, nStars = roofStarsFirstRow(n); i < RoofRows; i++, nStars += 2)
            {
                // Roof
                Console.Write(new string('-', (n - nStars) / 2));
                Console.Write(new string('*', nStars));
                Console.WriteLine(new string('-', (n - nStars) / 2));
            }
            // Base
            for (int i = 0; i < n / 2; i++)
            {
                Console.Write('|');
                Console.Write(new string('*', n - 2));
                Console.WriteLine('|');
            }
        }

        public static int roofStarsFirstRow(int n)
        {
            if (n % 2 == 0) return 2;
            else return 1;
        }

    }
}
