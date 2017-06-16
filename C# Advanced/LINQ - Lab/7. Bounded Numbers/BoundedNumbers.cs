namespace _7.Bounded_Numbers
{
    using System;
    using System.Linq;

    public class BoundedNumbers
    {
        public static void Main()
        {
            var boundaries = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            if (boundaries.Length != 2)
            {
                return;
            }

            var numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .Where(n => n >= boundaries[0] && n <= boundaries[1] ||
                        n >= boundaries[1] && n <= boundaries[0])
                .ToArray();

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
