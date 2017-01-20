using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sleepy_Cat
{
    class Program
    {
        static void Main(string[] args)
        {
            //  годината има 365 дни
            //  нормата за игра на Том е 30 000  минути в година
            //    •	Когато е на работа, стопанинът му си играе с него по 63 минути на ден.
            //    •	Когато почива, стопанинът му си играе с него по 127 минути на ден.
            var rest = int.Parse(Console.ReadLine());
            int playTime = (365 - rest) * 63 + rest * 127;
            if (playTime > 30000)
            {
                Console.WriteLine("Tom will run away");
                int exess = playTime - 30000;
                Console.WriteLine("{0} hours and {1} minutes more for play", exess / 60, exess % 60);
            }
            else
            {
                Console.WriteLine("Tom sleeps well");
                int less = 30000 - playTime;
                Console.WriteLine("{0} hours and {1} minutes less for play", less / 60, less % 60);
            }
        }
    }
}
