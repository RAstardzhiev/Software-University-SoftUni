namespace English_Name_of_Last_Digit
{
    using System;

    public class Last_Digit_Name
    {
        public static void Main(string[] args)
        {
            string number = Console.ReadLine();
            Console.WriteLine(LastDigitName(number));
        }

        public static string LastDigitName(string number)
        {
            char lastDigit = number[number.Length - 1];
            switch (lastDigit)
            {
                case '1': return "one";
                case '2': return "two";
                case '3': return "three";
                case '4': return "four";
                case '5': return "five";
                case '6': return "six";
                case '7': return "seven";
                case '8': return "eight";
                case '9': return "nine";
                case '0': return "zero";
                default: return "ERROR";
            }
        }
    }
}
