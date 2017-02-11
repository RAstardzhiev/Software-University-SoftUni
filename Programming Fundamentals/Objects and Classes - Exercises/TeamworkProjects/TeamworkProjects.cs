namespace TeamworkProjects
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class TeamworkProjects
    {
        public static void Main(string[] args)
        {
            List<string> messages = new List<string>();
            List<Team> teams = GetTeams();
            PrintReport(teams);
        }

        private static List<Team> GetTeams()
        {
            int numberOfTeams = int.Parse(Console.ReadLine());
            List<string> messages = new List<string>();
            List<Team> teams = new List<Team>();
            for (int i = 0; i < numberOfTeams; i++)
            {
                string[] teamInfo = Console.ReadLine().Split('-');
                if (teams.Any(x => x.Name.Equals(teamInfo[1])))
                {
                    messages.Add($"Team {teamInfo[1]} was already created!");
                }
                else if (teams.Any(x => x.Creator.Equals(teamInfo[0])))
                {
                    messages.Add($"{teamInfo[0]} cannot create another team!");
                }
                else
                {
                    teams.Add(new Team() { Name = teamInfo[1], Creator = teamInfo[0] });
                    messages.Add($"Team {teamInfo[1]} has been created by {teamInfo[0]}!");
                }
            }

            FillTeamsWithUsers(teams, messages);
            return teams;
        }

        private static void FillTeamsWithUsers(List<Team> teams, List<string> messages)
        {
            while (true)
            {
                string input = Console.ReadLine();
                if (input.ToLower().Equals("end of assignment"))
                {
                    break;
                }

                string[] userAndTeam = input
                    .Split('-', '>')
                    .ToArray()
                    .Where(x => x.Length > 0)
                    .ToArray();

                if (!teams.Any(x => x.Name.Equals(userAndTeam[1])))
                {
                    messages.Add($"Team {userAndTeam[1]} does not exist!");
                }
                else if (teams.Any(x => x.Users.Contains(userAndTeam[0])) || teams.Any(x => x.Creator.Equals(userAndTeam[0])))
                {
                    messages.Add($"Member {userAndTeam[0]} cannot join team {userAndTeam[1]}!");
                }
                else
                {
                    teams
                        .Where(x => x.Name.Equals(userAndTeam[1]))
                        .Select(x => { x.Users.Add(userAndTeam[0]); return x; })
                        .ToList();
                }
            }

            Console.WriteLine(string.Join("\n", messages));
        }

        private static void PrintReport(List<Team> teams)
        {
            teams = GetCorrectOrdering(teams);
            List<string> teamToDisband = new List<string>();
            foreach (Team team in teams)
            {
                if (team.Users.Count > 0)
                {
                    Console.WriteLine(team.Name);
                    Console.WriteLine($"- {team.Creator}");
                    Console.WriteLine($"-- {string.Join("\n-- ", team.Users)}");
                }
                else
                {
                    teamToDisband.Add(team.Name);
                }
            }

            Console.WriteLine("Teams to disband:\n" + string.Join("\n", teamToDisband.OrderBy(x => x)));
        }

        private static List<Team> GetCorrectOrdering(List<Team> teams)
        {
            teams = teams
                .OrderByDescending(x => x.Users.Count)
                .ThenBy(x => x.Name)
                .ToList();

            teams = teams
                .Select(x => { x.Users = x.Users.OrderBy(user => user).ToList(); return x; })
                .ToList();

            return teams;
        }
    }
}
