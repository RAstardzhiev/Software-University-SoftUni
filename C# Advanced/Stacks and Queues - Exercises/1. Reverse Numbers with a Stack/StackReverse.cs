namespace _1.Reverse_Numbers_with_a_Stack
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StackReverse
    {
        public static void Main()
        {
            Stack<int> numbers = new Stack<int>();

            Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList()
                .ForEach(strNumber => numbers.Push(int.Parse(strNumber)));

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
