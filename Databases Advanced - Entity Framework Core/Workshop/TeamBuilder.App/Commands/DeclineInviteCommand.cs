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
        private const string AlreadyMemberExceptionMessage = "You are already a member of team {0}! Invitation not found.";

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

            if (team.TeamUsers.Any(tu => tu.UserId == this.Session.User.Id))
            {
                throw new ArgumentException(string.Format(AlreadyMemberExceptionMessage, teamName));
            }

            if (team.Invitations == null || team.Invitations.Count == 0)
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
                .Include(t => t.Invitations)
                .Include(t => t.TeamUsers)
                .SingleOrDefault(t => t.Name.Equals(teamName, StringComparison.OrdinalIgnoreCase));

            if (team == null)
            {
                throw new ArgumentException(string.Format(TeamNotFoundExceptionMessage, teamName));
            }

            return team;
        }
    }
}
