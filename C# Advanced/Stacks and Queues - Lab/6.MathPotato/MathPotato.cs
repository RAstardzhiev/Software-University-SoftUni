namespace _6.MathPotato
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class MathPotato
    {
        public static void Main()
        {
            Queue<string> players = new Queue<string>();

            Console.ReadLine().Split().ToList().ForEach(name => players.Enqueue(name));
            var indexOfDeletion = int.Parse(Console.ReadLine());

            Console.WriteLine($"Last is {GetLastPlayer(indexOfDeletion, players)}");
        }

        private static string GetLastPlayer(int indexOfDeletion, Queue<string> players)
        {
            if (players.Count < 1 || players == null)
            {
                return string.Empty;
            }

            // Substract 1 from the index to match the Zero based indexation because of the reminder usage 
            indexOfDeletion--;
            var cycle = 1;

            while (players.Count > 1)
            {
                var currentDeletionIndex = indexOfDeletion % players.Count;

                for (int i = 0; i < players.Count; i++)
                {
                    if (i == currentDeletionIndex)
                    {
                        if (IsPrime(cycle))
                        {
                            Console.WriteLine($"Prime {players.Peek()}");
                            break;
                        }

                        Console.WriteLine($"Removed {players.Dequeue()}");
                        break;
                    }

                    var temp = players.Dequeue();
                    players.Enqueue(temp);
                }

                cycle++;
            }

            return players.Dequeue();
        }

        public static bool IsPrime(int number)
        {
            if (number == 1) return false;
            if (number == 2) return true;

            var boundary = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 2; i <= boundary; ++i)
            {
                if (number % i == 0) return false;
            }

            return true;
        }
    }
}
