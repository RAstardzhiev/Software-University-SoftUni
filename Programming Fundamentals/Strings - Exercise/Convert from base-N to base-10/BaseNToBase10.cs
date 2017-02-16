namespace Convert_from_base_N_to_base_10
{
    using System;
    using System.Linq;
    using System.Numerics;

    public class BaseNToBase10
    {
        public static void Main(string[] args)
        {
            BigInteger[] baseAndNumber = Console.ReadLine().Split(' ').Select(BigInteger.Parse).ToArray();
            Console.WriteLine(BaseNToBaseTen(baseAndNumber[0], baseAndNumber[1]));
        }

        private static BigInteger BaseNToBaseTen(BigInteger numberBase, BigInteger number)
        {
            BigInteger result = number % 10;
            number /= 10;

            for (int i = 1; true; i++)
            {
                BigInteger multiplier = BasePower((int)numberBase, i);
                result += (number % 10) * multiplier;
                number /= 10;
                if (number == 0)
                {
                    break;
                }
            }

            return result;
        }

        private static BigInteger BasePower(int number, int power)
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
