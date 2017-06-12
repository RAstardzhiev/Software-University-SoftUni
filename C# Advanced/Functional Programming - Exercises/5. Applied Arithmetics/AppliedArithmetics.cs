namespace _5.Applied_Arithmetics
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class AppliedArithmetics
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(new char[] { ' ', '\r', '\n', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse);

            var command = Console.ReadLine().ToLower().Trim();

            while (command != "end")
            {
                switch (command)
                {
                    case "add": // -> add 1 to each number
                        numbers = ForEach(numbers, n => n + 1);
                        break;
                    case "subtract": // -> subtract 1 from each number
                        numbers = ForEach(numbers, n => n - 1);
                        break;
                    case "multiply": // multiply each number by 2
                        numbers = ForEach(numbers, n => n * 2);
                        break;
                    case "print":
                        Console.WriteLine(string.Join(" ", numbers));
                        break;
                    default:
                        break;
                }

                command = Console.ReadLine().ToLower().Trim();
            }
        }

        public static IEnumerable<int> ForEach(IEnumerable<int> collection, Func<int, int> func)
        {
            return collection.Select(n => func(n));
        }
    }
}
