namespace _9.List_of_Predicates
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ListOfPredicates
    {
        public static void Main()
        {
            var endNumber = int.Parse(Console.ReadLine());
            var dividers = Console.ReadLine().Split().Select(int.Parse).Distinct();

            Queue<int> numbers = new Queue<int>();

            for (int i = 0; i <= endNumber; i++)
            {
                if (IsValidNumber(i, dividers, n => i % n == 0 ))
                {
                    numbers.Enqueue(i);
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }

        private static bool IsValidNumber(int number, IEnumerable<int> dividers, Func<int, bool> isDivisible)
        {
            foreach (var num in dividers)
            {
                if (!isDivisible(num))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
