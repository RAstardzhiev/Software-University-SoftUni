namespace _11.Tuple
{
    using System;
    using Models;

    public class StartUp
    {
        public static void Main()
        {
            TupleSolution();
        }

        private static void TupleSolution()
        {
            var input = Console.ReadLine().Split();
            var name = $"{input[0]} {input[1]}";
            var address = input[2];
            Console.WriteLine(new Tupple<string, string>(name, address));

            input = Console.ReadLine().Split();
            name = input[0];
            var litersOfBeer = int.Parse(input[1]);
            Console.WriteLine(new Tupple<string, int>(name, litersOfBeer));

            input = Console.ReadLine().Split();
            var integer = int.Parse(input[0]);
            var doubleValue = double.Parse(input[1]);
            Console.WriteLine(new Tupple<int, double>(integer, doubleValue));
        }
    }
}
