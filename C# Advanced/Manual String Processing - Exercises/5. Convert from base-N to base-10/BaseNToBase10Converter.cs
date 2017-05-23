namespace _5.Convert_from_base_N_to_base_10
{
    using System;
    using System.Numerics;

    public class BaseNToBase10Converter
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split(new char[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            int nBase = int.Parse(input[0]);
            BigInteger nBasedNumber = BigInteger.Parse(input[1]);

            // 2 <= N <= 10
            if (nBase < 2 || nBase > 10)
            {
                throw new ArgumentException("N must be in the range 2 to 10 (including)");
            }

            Console.WriteLine(ToTenBase(nBase, nBasedNumber));
        }

        private static BigInteger ToTenBase(int nBase, BigInteger nBasedNumber)
        {
            BigInteger tenBaseddNumber = 0;
            int power = 0;

            while (nBasedNumber > 0)
            {
                tenBaseddNumber += (nBasedNumber % 10) * ToThePowerOf(nBase, power);
                nBasedNumber /= 10;
                power++;
            }

            return tenBaseddNumber;
        }

        private static BigInteger ToThePowerOf(int number, int power)
        {
            BigInteger result = 1;

            for (int i = 0; i < power; i++)
            {
                result *= number;
            }

            return result;
        }
    }
}
