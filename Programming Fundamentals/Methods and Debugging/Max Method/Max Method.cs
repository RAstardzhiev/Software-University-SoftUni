namespace Max_Method
{
    using System;

    public class Max_Method
    {
        public static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

            Console.WriteLine(GetMax(GetMax(firstNumber, secondNumber), thirdNumber));
        }

        public static int GetMax(int a, int b)
        {
            return (a > b) ? a : b;
        }
    }
}
