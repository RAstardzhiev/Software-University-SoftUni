namespace TeamBuilder.App.Commands
{
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Linq;
    using System.Text;
    using TeamBuilder.App.Commands.Abstractions;
    using TeamBuilder.App.Interfaces;
    using TeamBuilder.Data;
    using TeamBuilder.Models;

    public class ShowTeamCommand : Command
    {
        private const int ArgsExactLength = 1;

        private const string TeamNotFoundExceptionMessage = "Team {0} not found!";

        public ShowTeamCommand(string[] cmdArgs, IUserSession session)
            : base(cmdArgs, session)
        {
        }

        // <teamName>
        public override string Execute(TeamBuilderContext context)
        {
            base.CmdArgsExactLengthValidation(ArgsExactLength);

            var teamName = this.CmdArgs[0];
            var team = context.Teams
                .Select(t => new
                {
                    t.Name, 
                    t.Acronym,
                    Users = t.TeamUsers
                        .Select(tu => tu.User.Username)
                        .ToArray()
                })
                .SingleOrDefault(t => t.Name.Equals(teamName, StringComparison.OrdinalIgnoreCase));

            if (team == null)
            {
                throw new ArgumentException(string.Format(TeamNotFoundExceptionMessage, teamName));
            }

            var sb = new StringBuilder();
            sb.AppendLine($"{teamName} {team.Acronym}")
                .AppendLine("Members:");

            foreach (var member in team.Users)
            {
                sb.AppendLine($"--{member}");
            }

            return sb.ToString().TrimEnd();
        }
    }
}
