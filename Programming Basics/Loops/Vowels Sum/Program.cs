using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vowels_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            s = s.ToLower();

            int sum = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == 'a') sum += 1;
                else if (s[i] == 'e') sum += 2;
                else if (s[i] == 'i') sum += 3;
                else if (s[i] == 'o') sum += 4;
                else if (s[i] == 'u') sum += 5;
            }

            Console.WriteLine(sum);
        }
    }
}
