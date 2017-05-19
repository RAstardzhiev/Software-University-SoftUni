namespace Math_Power
{
    using System;

    public class MathPower
    {
        public static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());
            Console.WriteLine(PowerOf(number, power));
        }

        private static double PowerOf(double number, int power)
        {
            double result = number;
            for (int i = 1; i < power; i++)
            {
                result *= number;
            }

            return result;
        }
    }
}
