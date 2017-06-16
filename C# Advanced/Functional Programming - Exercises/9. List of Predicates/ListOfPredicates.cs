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

            var predicates = dividers
                .Select(div => (Func<int, bool>)(n => n % div == 0))
                .ToArray();

            for (int i = 1; i <= endNumber; i++)
            {
                if (IsValid(predicates, i))
                {
                    numbers.Enqueue(i);
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }

        private static bool IsValid(Func<int, bool>[] predicates, int num)
        {
            foreach (var predicate in predicates)
            {
                if (!predicate(num))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
