namespace Unicode_Characters
{
    using System;

    public class StringToUnicode
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();

            foreach (char ch in input)
            {
                Console.Write($"\\u{(int)ch:x4}");
            }
        }
    }
}
