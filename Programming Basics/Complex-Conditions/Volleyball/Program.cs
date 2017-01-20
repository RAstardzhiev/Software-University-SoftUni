using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string year = Console.ReadLine().ToLower();
            var holidays = int.Parse(Console.ReadLine());
            var goHome = int.Parse(Console.ReadLine());

            // 2 / 3 от празничните дни.
            double playTime = 2 / 3.0 * holidays;
            // пътува до родния си град h пъти в годината, 
            // където играе волейбол със старите си приятели в неделя
            playTime += goHome;
            // годината има точно 48 уикенда
            // Влади не е на работа 3/4 от уикендите, в които е в София
            playTime += (48 - goHome) * (3.0 / 4);
            // през високосните години Влади играе 
            // с 15% повече волейбол от нормалното
            if (year.Equals("leap"))
                playTime *= 1.15;

            Console.WriteLine((int)playTime);
        }
    }
}
