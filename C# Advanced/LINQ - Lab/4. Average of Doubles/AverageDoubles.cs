namespace _4.Average_of_Doubles
{
    using System;
    using System.Linq;

    public class AverageDoubles
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split().Select(double.Parse);
            Console.WriteLine($"{numbers.Average():F2}");
        }
    }
}
