namespace _5.Concatenate_Strings
{
    using System;
    using System.Collections.Generic;

    public class ConcatenateStringsVs2
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var textCollector = new Queue<string>(n);

            for (int i = 0; i < n; i++)
            {
                textCollector.Enqueue(Console.ReadLine());
            }

            Console.WriteLine(string.Join(" ", textCollector));
        }
    }
}
