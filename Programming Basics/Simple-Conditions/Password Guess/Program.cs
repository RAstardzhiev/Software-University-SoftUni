using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password_Guess
{
    class Program
    {
        static void Main(string[] args)
        {
            string guess = Console.ReadLine();
            Console.WriteLine((guess.Equals("s3cr3t!P@ssw0rd")) ? "Welcome" : "Wrong password!");
        }
    }
}
