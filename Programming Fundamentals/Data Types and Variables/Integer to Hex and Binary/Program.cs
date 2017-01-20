using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integer_to_Hex_and_Binary
{
    public class Integer_to_Hex_and_Binary
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string hex = Convert.ToString(n, 16);
            hex = hex.ToUpper();
            Console.WriteLine(hex);
            string bin = Convert.ToString(n, 2);
            Console.WriteLine(bin);
        }
    }
}
