namespace _3.Non_Digit_Count
{
    using System;
    using System.Text.RegularExpressions;

    public class NonDigitCount
    {
        public static void Main()
        {
            var text = Console.ReadLine();
            var nonDigits = Regex.Matches(text, @"\D").Count;
            Console.WriteLine($"Non-digits: {nonDigits}");
        }
    }
}
