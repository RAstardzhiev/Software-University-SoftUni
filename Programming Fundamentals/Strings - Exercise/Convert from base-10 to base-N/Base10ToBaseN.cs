namespace Convert_from_base_10_to_base_N
{
    using System;
    using System.Linq;
    using System.Numerics;
    using System.Text;

    public class Base10ToBaseN
    {
        public static void Main(string[] args)
        {
            BigInteger[] baseAndNumber = Console.ReadLine().Split(' ').Select(BigInteger.Parse).ToArray();
            Console.WriteLine(NBaseNumber(baseAndNumber[0], baseAndNumber[1]));
        }

        private static string NBaseNumber(BigInteger targetBase, BigInteger tenBaseNumber)
        {
            StringBuilder sb = new StringBuilder();

            while (tenBaseNumber > 0)
            {
                int reminder = (int)BigInteger.Remainder(tenBaseNumber, targetBase);
                tenBaseNumber = BigInteger.Divide(tenBaseNumber, targetBase);
                sb.Insert(0, reminder);
            }
            
            return sb.ToString();
        }
    }
}
