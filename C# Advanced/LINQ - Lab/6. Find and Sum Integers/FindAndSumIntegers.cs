namespace _6.Find_and_Sum_Integers
{
    using System;
    using System.Linq;

    public class FindAndSumIntegers
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split()
                .Select(str =>
                    {
                        double number;
                        var isNumber = double.TryParse(str, out number);
                        return new { number, isNumber };
                    })
                .Where(obj => obj.isNumber)
                .Select(obj => obj.number)
                .ToArray();

            Console.WriteLine(numbers.Length == 0 
                ? "No match"
                : $"{numbers.Sum()}");
        }
    }
}
