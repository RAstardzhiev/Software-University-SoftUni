namespace Numbers_in_Reversed_Order
{
    using System;

    public class Reverse_Numbers
    {
        public static void Main(string[] args)
        {
            decimal number = decimal.Parse(Console.ReadLine());
            PrintReversedNumber(number);
        }

        public static void PrintReversedNumber(decimal number)
        {
            string numberToString = number.ToString();
            for (int i = numberToString.Length - 1; i >= 0; i--)
            {
                Console.Write(numberToString[i]);
            }
        }
    }
}
