namespace Letters_Change_Numbers
{
    using System;
    using System.Linq;
    using System.Text;

    public class LettersChangeNumbers
    {
        public static void Main(string[] args)
        {
            /*
             * For example, you are given the sequence "A12b s17G". (two strings – "A12b" and "s17G")
             * We do the operations on each and sum them. We start with the letter before the number on the first string. 
             * A is Uppercase and its position in the alphabet is 1. So we divide the number 12 with the position 1 (12/1 = 12). 
             * Then we move to the letter after the number. b is lowercase and its position is 2. So we add 2 to the resulted number (12+2=14). 
             * Similarly for the second string s is lowercase and its position is 19 so we multiply it with the number (17*19 = 323). 
             * Then we have Uppercase G with position 7, so we subtract it from the resulted number (323 – 7 = 316). 
             * Finally we sum the 2 results and we get 14 + 316=330;
             * 
             * • The count of the strings will be in the range [1 … 10].
             * • The numbers between the letters will be integers in range [1 … 2 147 483 647].
             * • Time limit: 0.3 sec. Memory limit: 16 MB.
             * 
             * Print at the console: the total sum of all processed numbers rounded up to two digits after the decimal separator.
             */

            string[] input = Console.ReadLine().Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            decimal totalSum = 0;
            for (int i = 0; i < input.Length; i++)
            {
                totalSum += StringValue(input[i]);
            }

            Console.WriteLine($"{totalSum:F2}");
        }

        private static decimal StringValue(string str)
        {
            /*
             * First you start with the letter before the number. 
             * If it's Uppercase you divide the number by the letter's position in the alphabet. 
             * If it's lowercase you multiply the number with the letter's position. 
             */
            decimal number = ExtractNumber(str);
            if (char.IsUpper(str[0]))
            {
                byte letterPosition = (byte)((str[0] - 'A') + 1);
                number /= letterPosition;
            }
            else
            {
                byte letterPosition = (byte)((str[0] - 'a') + 1);
                number *= letterPosition;
            }

            /*
             * Then you move to the letter after the number. 
             * If it's Uppercase you subtract its position from the resulted number. 
             * If it's lowercase you add its position to the resulted number. 
             */
             if (char.IsUpper(str.Last()))
            {
                byte letterPosition = (byte)((str.Last() - 'A') + 1);
                number -= letterPosition;
            }
             else
            {
                byte letterPosition = (byte)((str.Last() - 'a') + 1);
                number += letterPosition;
            }

            return number;
        }

        private static decimal ExtractNumber(string str)
        {
            StringBuilder result = new StringBuilder(str.Length - 2);
            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsDigit(str[i]))
                {
                    result.Append(str[i]);
                }
            }

            return decimal.Parse(result.ToString());
        }
    }
}
