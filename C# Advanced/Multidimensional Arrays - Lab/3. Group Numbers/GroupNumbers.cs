namespace _3.Group_Numbers
{
    using System;
    using System.Linq;

    public class GroupNumbers
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse);

            Console.WriteLine(string.Join(" ", numbers.Where(n => Math.Abs(n) % 3 == 0)));
            Console.WriteLine(string.Join(" ", numbers.Where(n => Math.Abs(n) % 3 == 1)));
            Console.WriteLine(string.Join(" ", numbers.Where(n => Math.Abs(n) % 3 == 2)));
        }
    }
}
