namespace TeamBuilder.App.Commands
{
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Linq;
    using TeamBuilder.App.Commands.Abstractions;
    using TeamBuilder.App.Interfaces;
    using TeamBuilder.Data;
    using TeamBuilder.Models;
    using Z.EntityFramework.Plus;

    public class DisbandCommand : Command
    {
        private const string Success = "{0} has disbanded!";
        private const int ArgsExactLength = 1;

        private const string TeamNotFoundExceptionMessage = "Team {0} not found!";
        private const string NotAllowedExceptionMessage = "Not allowed!";

        public DisbandCommand(string[] cmdArgs, IUserSession session) 
            : base(cmdArgs, session)
        {
        }

        // <teamName>
        public override string Execute(TeamBuilderContext context)
        {
            base.MustBeLoggedIn();
            base.CmdArgsExactLengthValidation(ArgsExactLength);

            var teamName = this.CmdArgs[0];
            var team = this.GetTeam(context, teamName);

            context.Remove(team);
            context.SaveChanges();

            return string.Format(Success, teamName);
        }

        private Team GetTeam(TeamBuilderContext context, string teamName)
        {
            var team = context.Teams
                .SingleOrDefault(t => t.Name.Equals(teamName, StringComparison.OrdinalIgnoreCase));

            if (team == null)
            {
                throw new ArgumentException(string.Format(TeamNotFoundExceptionMessage, teamName));
            }

            if (this.Session.User.Id != team.CreatorId)
            {
                throw new InvalidOperationException(NotAllowedExceptionMessage);
            }

            return team;
        }
    }
}
