namespace Reverse_String
{
    using System;
    using System.Linq;

    public class ReverseString
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Console.WriteLine(string.Join(string.Empty, input.ToCharArray().Reverse()));
        }
    }
}
