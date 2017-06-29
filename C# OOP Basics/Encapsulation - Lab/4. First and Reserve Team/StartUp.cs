namespace _4.First_and_Reserve_Team
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var numberOfPeople = int.Parse(Console.ReadLine());
            var team = new Team("Name");

            while (numberOfPeople > 0)
            {
                var input = Console.ReadLine().Split();

                var person = new Person(input[0], input[1], int.Parse(input[2]), double.Parse(input[3]));
                team.AddPlayer(person);

                numberOfPeople--;
            }

            Console.WriteLine($"First team have {team.FirstTeam.Count} players");
            Console.WriteLine($"Reserve team have {team.ReserveTeam.Count} players");
        }
    }
}
