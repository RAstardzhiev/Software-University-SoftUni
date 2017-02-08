namespace Big_Factorial
{
    using System;
    using System.Numerics;

    public class BigFactorial
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger factorial = 1;
            for (int i = 1; i <= n; i++)
            {
                factorial = BigInteger.Multiply(factorial, i);
            }

            Console.WriteLine(factorial);
        }
    }
}
