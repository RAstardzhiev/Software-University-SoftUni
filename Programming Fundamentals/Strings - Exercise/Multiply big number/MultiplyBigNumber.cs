namespace Multiply_big_number
{
    using System;
    using System.Text;

    public class MultiplyBigNumber
    {
        public static void Main(string[] args)
        {
            /*
             * You are given two lines - the first one can be a really big number (0 to 10^50). 
             * The second one will be a single digit number (0 to 9). You must display the product of these numbers. 
             * Note: do not use the BigInteger or BigDecimal classes for solving this problem.
             */
            string bigNumber = Console.ReadLine().TrimStart('0');
            byte multiplyer = byte.Parse(Console.ReadLine());
            Console.WriteLine((bigNumber.Equals("0") || multiplyer == 0) ? "0" : Multiply(bigNumber, multiplyer));
        }

        private static string Multiply(string bigNumber, byte multiplyer)
        {
            StringBuilder result = new StringBuilder(bigNumber.Length + (bigNumber.Length / 2));
            int carry = 0;

            for (int i = bigNumber.Length - 1; i >= 0; i--)
            {
                int digit = ((bigNumber[i] - '0') * multiplyer) + carry;
                result.Insert(0, digit % 10);
                carry = digit / 10;
            }

            if (carry > 0)
            {
                result.Insert(0, carry);
            }

            return result.ToString();
        }
    }
}
