using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Half_Sum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int digits = int.Parse(Console.ReadLine());

            int[] ns = new int[digits];
            for (int i = 0; i < digits; i++)
                ns[i] = int.Parse(Console.ReadLine());

            int sum = 0;
            for (int i = 0; i < ns.Length; i++)
                sum += ns[i];

            Boolean isThere = false;
            for (int i = 0; i < ns.Length; i++)
            { 
                if (ns[i] == sum - ns[i])
                {
                    isThere = true;
                    sum = ns[i];
                    break;
                }
            }

            if (isThere) Console.WriteLine("Yes Sum = {0}", sum);
            else
            {
                int max = ns[0];
                for (int i = 1; i < ns.Length; i++)
                    if (ns[i] > max)
                        max = ns[i];
                Console.WriteLine("No Diff = {0}", Math.Abs((sum - max) - max));
            }
        }
    }
}
