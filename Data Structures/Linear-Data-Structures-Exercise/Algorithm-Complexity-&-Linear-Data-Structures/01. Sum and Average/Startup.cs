namespace _01._Sum_and_Average
{
    using System;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse);

            var isEmpty = !numbers.Any();

            var sum = isEmpty ? 0 : numbers.Sum();
            var avg = isEmpty ? 0 : numbers.Average();

            Console.WriteLine($"Sum={sum}; Average={avg:F2}");
        }
    }
}
