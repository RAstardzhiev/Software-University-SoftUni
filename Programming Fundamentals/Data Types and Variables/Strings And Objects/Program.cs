using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings_And_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            String hello = "Hello";
            String world = "World";
            //String[] gatheringArray = { hello, " ", world };
            //String both = gatheringArray.ToString();
            hello = hello + " " + world;
            String both = hello;
            Console.WriteLine(both);
        }
    }
}
