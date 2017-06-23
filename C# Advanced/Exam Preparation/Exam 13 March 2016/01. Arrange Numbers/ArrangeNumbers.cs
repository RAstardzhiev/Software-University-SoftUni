namespace _01.Arrange_Numbers
{
    using System;
    using System.Linq;

    public class ArrangeNumbers
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(new char[] { ' ', ',', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(str => str.Length > 1 ? str.TrimStart('0') : str)
                .ToList();

            numbers.Sort(new CustomComparer());
            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}
