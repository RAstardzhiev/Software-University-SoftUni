using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reversed_chars
{
    public class Reversed_chars
    {
        public static void Main(string[] args)
        {
            char[] input = new char[3];
            for (int i = 0; i < input.Length; i++)
            {
                input[i] = Console.ReadLine()[0];
            }
            for (int i = input.Length - 1; i >= 0; i--)
            {
                Console.Write(input[i]);
            }
        }
    }
}
