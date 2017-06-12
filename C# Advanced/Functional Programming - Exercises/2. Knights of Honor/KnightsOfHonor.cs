namespace _2.Knights_of_Honor
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class KnightsOfHonor
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(new char[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            Action<IEnumerable<string>> action = collection => Console.WriteLine(string.Join(Environment.NewLine, collection.Select(name => $"Sir {name}")));
            action(input);
        }
    }
}
