namespace _10.Unicode_Characters
{
    using System;

    public class UnicodeCharacters
    {
        public static void Main()
        {
            var symbols = Console.ReadLine().ToCharArray();

            foreach (var ch in symbols)
            {
                Console.Write(GetUnicode(ch));
            }
        }

        private static string GetUnicode(char character)
        {
            return $"\\u{((int)character).ToString("X4")}".ToLower();
        }
    }
}
