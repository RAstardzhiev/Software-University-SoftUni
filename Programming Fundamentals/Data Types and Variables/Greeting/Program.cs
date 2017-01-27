using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greeting
{
    class Program
    {
        static void Main(string[] args)
        {
            String firstName = Console.ReadLine();
            String lastName = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Hello, {0} {1}. You are {2} years old.", firstName, lastName, age);
        }
    }
}
