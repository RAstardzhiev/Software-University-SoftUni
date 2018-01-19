namespace _02._Sort_Words
{
    using System;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            Console.WriteLine(string.Join(" ", 
                Console.ReadLine()
                .Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries)
                .OrderBy(x => x)));
        }
    }
}
