namespace Fibonacci_Numbers
{
    using System;

    public class Fibonacci_Numbers
    {
        public static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(Fib(number));
        }

        public static int Fib(int number)
        {
            int fibunaciNumberr = 1;
            int lastFibonaci = 0;
            for (int i = 0; i < number; i++)
            {
                int temp = fibunaciNumberr;
                fibunaciNumberr += lastFibonaci;
                lastFibonaci = temp;
            }
            
            return fibunaciNumberr;
        }
    }
}
