using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battles
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstPlayer = int.Parse(Console.ReadLine());
            int secondPlayer = int.Parse(Console.ReadLine());
            int maxBattles = int.Parse(Console.ReadLine());

            for (int i = 1; i <= firstPlayer && maxBattles > 0; i++)
            {
                for (int j = 1; j <= secondPlayer && maxBattles > 0; j++, maxBattles--)
                {
                    Console.Write("({0} <-> {1}) ", i, j);
                }

            }


        }
    }
}
