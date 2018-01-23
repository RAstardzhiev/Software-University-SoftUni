namespace _01.ReverseNumbersWithStack
{
    using System;
    using System.Collections.Generic;

    public class Startup
    {
        public static void Main()
        {
            Console.WriteLine(string.Join(" ", new Stack<string>(
                Console.ReadLine()
                .Split(' '))));
        }
    }
}
