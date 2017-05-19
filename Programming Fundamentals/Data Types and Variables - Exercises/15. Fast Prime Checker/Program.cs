using System;

namespace Fast_Prime_Checker
{
    public class Fast_Prime_Checker
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 2; i <= n; i++)
            {
                bool isPrime = true;
                for (int divider = 2; divider <= Math.Sqrt(i); divider++)
                {
                    if (i % divider == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                Console.WriteLine($"{i} -> {isPrime}");
            }
        }
    }
}
