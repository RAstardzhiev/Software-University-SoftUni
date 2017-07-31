namespace _02.Card_Rank
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

            var cardRanks = Enum.GetValues(typeof(CardRanks));
            foreach (var rank in cardRanks)
            {
                Console.WriteLine($"Ordinal value: {(int)rank}; Name value: {rank}");
            }
        }
    }
}
