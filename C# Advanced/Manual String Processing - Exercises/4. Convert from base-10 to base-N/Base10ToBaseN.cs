namespace _4.Convert_from_base_10_to_base_N
{
    using System;
    using System.Numerics;
    using System.Text;

    public class Base10ToBaseN
    {
        public static void Main()
        {
            string[] inpit = Console.ReadLine().Split(new char[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            int newBase = int.Parse(inpit[0]);
            BigInteger tenBased = BigInteger.Parse(inpit[1]);

            Console.WriteLine(ConvertToBase(tenBased, newBase));
        }

        private static BigInteger ConvertToBase(BigInteger tenBased, int newBase)
        {
            // 2 <= N <= 10
            if (newBase < 2 || newBase > 10)
            {
                throw new ArgumentException("N must be between 2 and 10 (including)");
            }

            StringBuilder sb = new StringBuilder();

            while (tenBased > 0)
            {
                sb.Insert(0, tenBased % newBase);
                tenBased /= newBase;
            }

            return BigInteger.Parse(sb.ToString());
        }
    }
}
