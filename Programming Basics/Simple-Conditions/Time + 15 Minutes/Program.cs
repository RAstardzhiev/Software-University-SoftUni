using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time_15_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            var hours = int.Parse(Console.ReadLine());
            var minutes = int.Parse(Console.ReadLine()) + 15;
            int allMinutes = hours * 60 + minutes;
            Console.Write("{0}:", allMinutes / 60 % 24);
            if (allMinutes % 60 < 10)
                Console.Write("0");
            Console.WriteLine(allMinutes % 60);
        }
    }
}
