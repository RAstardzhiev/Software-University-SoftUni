namespace Prime_Checker
{
    using System;

    public class Prime_Checker
    {
        public static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            Console.WriteLine(IsPrime(number));
        }

        public static Boolean IsPrime(long number)
        {
            if (number == 0 || number == 1)
            {
                return false;
            }

            int loopBorder = (int)Math.Sqrt(number);
            for (int i = 2; i <= loopBorder; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}