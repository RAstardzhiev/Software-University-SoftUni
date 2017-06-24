namespace _04.Champions_League
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class ChampionLeague
    {
        public static void Main()
        {
            var teams = GetTeams();
            PrintTeams(teams);
        }

        private static void PrintTeams(HashSet<Team> teams)
        {
            var sb = new StringBuilder();

            foreach (var team in teams.OrderByDescending(t => t.Wins).ThenBy(t => t.Name))
            {
                sb.AppendLine(team.Name);
                sb.AppendLine($"- Wins: {team.Wins}");
                sb.AppendLine($"- Opponents: {string.Join(", ", team.Opponents.OrderBy(n => n))}");
            }

            Console.WriteLine(sb);
        }

        private static HashSet<Team> GetTeams()
        {
            var teams = new HashSet<Team>();
            var input = Console.ReadLine().Split(new[] { " | " }, StringSplitOptions.RemoveEmptyEntries);

            while (input[0] != "stop")
            {
                var firstTeam = input[0];
                var secondTeam = input[1];
                var firstHost = input[2].Split(':').Select(int.Parse).ToArray();
                var secondHost = input[3].Split(':').Select(int.Parse).ToArray();
                var totalGoals = new int[] 
                {
                    firstHost[0] + secondHost[1],
                    firstHost[1] + secondHost[0]
                };

                var winner = string.Empty;
                var loser = string.Empty;

                if (totalGoals[0] > totalGoals[1])
                {
                    winner = firstTeam;
                    loser = secondTeam;
                }
                else if (totalGoals[0] < totalGoals[1])
                {
                    winner = secondTeam;
                    loser = firstTeam;
                }
                else
                {
                    if (firstHost[1] > secondHost[1])
                    {
                        winner = secondTeam;
                        loser = firstTeam;
                    }
                    else
                    {
                        winner = firstTeam;
                        loser = secondTeam;
                    }
                }

                UpdateTeams(teams, winner, loser, 1);
                UpdateTeams(teams, loser, winner, 0);

                input = Console.ReadLine().Split(new[] { " | " }, StringSplitOptions.RemoveEmptyEntries);
            }

            return teams;
        }

        private static void UpdateTeams(HashSet<Team> teams, string teamName, string opponentName, int winsToAdd)
        {
            var currentTeam = teams.Where(t => t.Name == teamName).FirstOrDefault();

            if (currentTeam == null)
            {
                teams.Add(new Team
                {
                    Name = teamName,
                    Wins = winsToAdd,
                    Opponents = new List<string>() { opponentName }
                });
            }
            else
            {
                currentTeam.Wins += winsToAdd;
                currentTeam.Opponents.Add(opponentName);
            }
        }
    }
}
