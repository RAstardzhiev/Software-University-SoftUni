using System;

namespace Vowel_or_Digit
{
    public class Vowel_or_Digit
    {
        public static void Main(string[] args)
        {
            char c = Console.ReadLine()[0];
            if (Char.IsDigit(c))
                Console.WriteLine("digit");
            // A, E, I, O, U, and sometimes Y
            else if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u' || c == 'y' || c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U' || c == 'Y')
                Console.WriteLine("vowel");
            else
                Console.WriteLine("other");
        }
    }
}
