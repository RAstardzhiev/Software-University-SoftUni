using System;

namespace Exchange_Variable_Values
{
    public class Exchange_Variable_Values
    {
        public static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine()); ;
            int b = int.Parse(Console.ReadLine()); ;
            Console.WriteLine("Before:\na = {0}\nb = {1}", a, b);
            int temp = a;
            a = b;
            b = temp;
            Console.WriteLine("After:\na = {0}\nb = {1}", a, b);
        }
    }
}
