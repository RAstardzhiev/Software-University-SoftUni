namespace Printing_Triangle
{
    using System;

    public class PrintingTriangle
    {
        public static void Main(string[] args)
        {
            int triangleSize = int.Parse(Console.ReadLine());
            for (int i = 1; i <= triangleSize; i++)
            {
                PrintLine(1, i);
            }

            for (int i = triangleSize - 1; i > 0; i--)
            {
                PrintLine(1, i);
            }
        }

        public static void PrintLine(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write($"{i} ");
            }

            Console.WriteLine();
        }
    }
}
