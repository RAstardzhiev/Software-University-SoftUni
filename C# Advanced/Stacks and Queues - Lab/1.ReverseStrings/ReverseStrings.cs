namespace _1.ReverseStrings
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ReverseStrings
    {
        public static void Main()
        {
            var reversed = new Stack<char>();
            Console.ReadLine().ToCharArray().ToList().ForEach(x => reversed.Push(x));
            Console.WriteLine(string.Join(string.Empty, reversed));
        }
    }
}
