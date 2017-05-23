namespace _2.String_Length
{
    using System;

    public class StringLength
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            int asteriskCount = 20 - input.Length;

            if (asteriskCount > 0)
            {
                Console.WriteLine($"{input}{new string('*', asteriskCount)}");
            }
            else
            {
                Console.WriteLine(input.Substring(0, 20));
            }
        }
    }
}
