namespace _01.Card_Suit
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var command = Console.ReadLine();
            ProcessCommand(command);
        }

        private static void ProcessCommand(string command)
        {
            Console.WriteLine($"{command}:");

            var suits = Enum.GetValues(typeof(CardSuits));
            foreach (var suit in suits)
            {
                Console.WriteLine($"Ordinal value: {(int)suit}; Name value: {suit}");
            }
        }
    }
}
