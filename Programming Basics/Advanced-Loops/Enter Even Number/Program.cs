using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enter_Even_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            while (true)
            {
                while (true)
                {
                    try
                    {
                        Console.Write("Enter even number: ");
                        n = int.Parse(Console.ReadLine());
                    }
                    catch 
                    {
                        Console.WriteLine("Invalid number!");
                    }
                    if (n != 0) break;
                }
                if (n % 2 == 0) break;
                else Console.WriteLine("The number is not even.");
            }
            Console.WriteLine("Even number entered: {0}", n);
        }
    }
}
