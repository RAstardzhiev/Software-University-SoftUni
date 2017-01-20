using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Latin_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            for (char i = 'a'; i < 'z'; i++)
                Console.Write(i + ", ");
            Console.WriteLine("z.");
        }
    }
}
