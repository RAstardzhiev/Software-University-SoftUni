using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Seconds
{
    class Program
    {
        static void Main(string[] args)
        {
            var sec1 = int.Parse(Console.ReadLine());
            var sec2 = int.Parse(Console.ReadLine());
            var sec3 = int.Parse(Console.ReadLine());
            int sum = sec1 + sec2 + sec3;

            int min = sum / 60, sec = sum % 60;
            Console.WriteLine((sec < 10) ? min + ":0" + sec : min + ":" + sec);
        }
    }
}
