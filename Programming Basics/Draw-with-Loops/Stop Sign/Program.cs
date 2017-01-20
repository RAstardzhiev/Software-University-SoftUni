using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stop_Sign
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            // First Row
            Console.WriteLine("{0}{1}{0}", new string('.', n + 1), new string('_', n  * 2 + 1));

            for (int i = 0, dots = n, downScores = n * 2 - 1; i < n; i++, dots--, downScores += 2)
            {
                Console.WriteLine("{0}//{1}\\\\{0}", new string('.', dots), new string('_', downScores));
            }

            // Middle
            Console.WriteLine("//{0}STOP!{0}\\\\", new string('_', ((n * 2 - 1) + n * 2 - 5) / 2));

            // Down Side
            Console.WriteLine("\\\\{0}//", new string('_', (n * 2 - 1) + n * 2));
            for (int i = 0, dots = 1, downScores = (n * 2 - 1) + n * 2 - 5 / 2; i < n - 1; dots++, downScores -= 2, i++)
            {
                Console.WriteLine("{0}\\\\{1}//{0}", new string('.', dots), new string('_', downScores));
            }

            // Last Row
        }
    }
}
