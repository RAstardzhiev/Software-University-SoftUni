namespace _3.DecimalToBinaryConverter
{
    using System;
    using System.Collections.Generic;

    public class DecimalBinaryConverter
    {
        public static void Main()
        {
            int decimalNumber = int.Parse(Console.ReadLine());

            if (decimalNumber == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(GetBinary(decimalNumber));
            }
        }

        private static string GetBinary(int decimalNumber)
        {
            Stack<byte> binary = new Stack<byte>();

            while (decimalNumber > 0)
            {
                binary.Push((byte)(decimalNumber % 2));
                decimalNumber /= 2;
            }

            return string.Join(string.Empty, binary);
        }
    }
}
