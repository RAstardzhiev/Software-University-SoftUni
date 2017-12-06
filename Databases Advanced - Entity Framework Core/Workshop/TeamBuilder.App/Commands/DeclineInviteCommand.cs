namespace TeamBuilder.App.Commands
{
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Linq;
    using TeamBuilder.App.Commands.Abstractions;
    using TeamBuilder.App.Interfaces;
    using TeamBuilder.Data;
    using TeamBuilder.Models;

    public class DeclineInviteCommand : Command
    {
        private const string Success = "Invite from {0} declined.";
        private const int ArgsExactLength = 1;

        private const string TeamNotFoundExceptionMessage = "Team {0} not found!";
        private const string MissingInvitationExceptionMessage = "You are not invated in team {0}!";

        public DeclineInviteCommand(string[] cmdArgs, IUserSession session) 
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

            if (team.Invitations == null)
            {
                throw new ArgumentException(string.Format(MissingInvitationExceptionMessage, teamName));
            }

            var invitation = team.Invitations.First();
            invitation.IsActive = false;
            context.SaveChanges();

            return string.Format(Success, teamName);
        }

        private Team GetTeam(TeamBuilderContext context, string teamName)
        {
            var team = context.Teams
                .Include(t => t.Invitations
                    .Where(i => i.InvitedUserId == this.Session.User.Id && i.IsActive == true))
                .SingleOrDefault(t => t.Name.Equals(teamName, StringComparison.OrdinalIgnoreCase));

            if (team == null)
            {
                throw new ArgumentException(string.Format(TeamNotFoundExceptionMessage, teamName));
            }

            return team;
        }
    }
}
