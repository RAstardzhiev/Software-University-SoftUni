namespace Master_Number
{
    using System;
    using System.Linq;

    public class Master_Number
    {
        public static void Main(string[] args)
        {
            int numberRange = int.Parse(Console.ReadLine());
            PrintMasterNumbers(numberRange);
        }

        public static void PrintMasterNumbers(int numberRange)
        {
            for (int i = 1; i <= numberRange; i++)
            {
                if (ContainsEvenDigits(i) && SumOfDigits(i) % 7 == 0 && IsPalindrome(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        public static Boolean ContainsEvenDigits(int number)
        {
            while (number > 0)
            {
                int digit = number % 10;
                if (digit % 2 == 0)
                {
                    return true;
                }

                number /= 10;
            }

            return false;
        }

        public static int SumOfDigits(int number)
        {
            int sum = 0;
            while (number > 0)
            {
                sum += number % 10;
                number /= 10;
            }

            return sum;
        }

        public static Boolean IsPalindrome(int number)
        {
            string numberAsString = string.Empty + number;
            string reversedNumber = new string(numberAsString.Reverse().ToArray());
            return numberAsString.Equals(reversedNumber);
        }
    }
}
