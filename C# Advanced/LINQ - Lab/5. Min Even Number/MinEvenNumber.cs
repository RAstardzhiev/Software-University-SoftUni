namespace _5.Min_Even_Number
{
    using System;
    using System.Linq;

    public class MinEvenNumber
    {
        public static void Main()
        {
            var evenNumbers = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .Where(n => n % 2 == 0)
                .ToArray();

            Console.WriteLine(evenNumbers.Length == 0 
                ? "No match"
                : $"{evenNumbers.Min():F2}");
        }
    }
}
