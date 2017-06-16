namespace _1.Take_Two
{
    using System;
    using System.Linq;

    public class TakeTwo
    {
        public static void Main()
        {
            Console.WriteLine(string.Join(" ", Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .Where(n => n >= 10 && n <= 20)
                .Distinct()
                .Take(2)));
        }
    }
}
