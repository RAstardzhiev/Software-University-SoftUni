using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Left_and_Right_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int fN = int.Parse(Console.ReadLine());
            int sum1 = 0, sum2 = 0;
            for (int i = 0; i < fN; i++)
                sum1 += int.Parse(Console.ReadLine());
            for (int i = 0; i < fN; i++)
                sum2 += int.Parse(Console.ReadLine());

            if (sum1 == sum2)
                Console.WriteLine("Yes, sum = {0}", sum1);
            else
                Console.WriteLine("No, diff = {0}", Math.Abs(sum1 - sum2));

        }
    }
}
