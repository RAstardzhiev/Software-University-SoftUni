using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean_Variable
{
    class Program
    {
        static void Main(string[] args)
        {
            String input = Console.ReadLine();
            Console.WriteLine(input.ToLower().Equals("true") ? "Yes" : input.ToLower().Equals("false") ? "No" : "");
        }
    }
}
