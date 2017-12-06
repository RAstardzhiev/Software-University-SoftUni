namespace TeamBuilder.App.Commands
{
    using System;
    using System.Linq;
    using TeamBuilder.App.Commands.Abstractions;
    using TeamBuilder.App.Interfaces;
    using TeamBuilder.Data;
    using TeamBuilder.Models;

    public class AcceptInviteCommand : Command
    {
        private const string Success = "User {0} joined team {1}!";
        private const int ArgsExactLength = 1;

        private const string TeamNotExistExceptionMessage = "Team {0} not found!";
        private const string MissingInvitationExceptionMessage = "Invite from {0} is not found!";

        public AcceptInviteCommand(string[] cmdArgs, IUserSession session) 
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

            var invitaition = context.Invitations
                .SingleOrDefault(i => i.TeamId == team.Id && i.InvitedUserId == this.Session.User.Id);

            // If user is not invited
            if (invitaition == null || invitaition.IsActive == false)
            {
                throw new ArgumentException(string.Format(MissingInvitationExceptionMessage, teamName));
            }

            // Accept user in the team
            invitaition.IsActive = false;
            var mapping = new UserTeam();
            mapping.User = this.Session.User;
            mapping.Team = team;

            context.UsersTeams.Add(mapping);
            context.SaveChanges();

            return string.Format(Success, this.Session.User.Username, teamName);
        }

        private Team GetTeam(TeamBuilderContext context, string teamName)
        {
            var team = context.Teams
                .SingleOrDefault(t => t.Name.Equals(teamName, StringComparison.OrdinalIgnoreCase));

            if (team == null)
            {
                throw new ArgumentException(string.Format(TeamNotExistExceptionMessage, teamName));
            }

            return team;
        }
    }
}
