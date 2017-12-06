namespace TeamBuilder.App.Commands
{
    using System;
    using System.Linq;
    using TeamBuilder.App.Commands.Abstractions;
    using TeamBuilder.App.Interfaces;
    using TeamBuilder.Data;
    using TeamBuilder.Models;

    public class CreateTeamCommand : Command
    {
        private const string Success = "Team {0} successfully created!";
        private const int ArgsaMinLength = 2;

        private const string TeamExistsExceptionMessage = "Team {0} exists!";
        private const string AcronymNotValidExceptionMessage = "Acronym {0} not valid!";

        public CreateTeamCommand(string[] cmdArgs, IUserSession session) 
            : base(cmdArgs, session)
        {
        }

        // <name> <acronym> <description>
        public override string Execute(TeamBuilderContext context)
        {
            base.MustBeLoggedIn();
            base.CmdArgsMinLengthValidation(ArgsaMinLength);

            var name = this.CmdArgs[0];
            var acronym = this.CmdArgs[1];

            var team = this.GetTeam(context, name, acronym);

            context.Teams.Add(team);
            context.SaveChanges();

            return string.Format(Success, name);
        }

        private Team GetTeam(TeamBuilderContext context, string name, string acronym)
        {
            var team = context.Teams
                .SingleOrDefault(t => t.Name.Equals(name, StringComparison.OrdinalIgnoreCase));

            if (team != null)
            {
                throw new ArgumentException(string.Format(TeamExistsExceptionMessage, name));
            }

            team = new Team();
            var acronymErrMsg = string.Format(AcronymNotValidExceptionMessage, acronym);
            base.AssignValueArgument(team, acronymErrMsg, t => t.Acronym = acronym);
            team.Name = name;
            team.Creator = this.Session.User;

            if (this.CmdArgs.Length > ArgsaMinLength)
            {
                var description = string.Join(" ", this.CmdArgs.Skip(ArgsaMinLength));
                team.Description = description;
            }

            return team;
        }
    }
}
