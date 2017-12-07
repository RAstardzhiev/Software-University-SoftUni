namespace TeamBuilder.App.Commands
{
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Linq;
    using TeamBuilder.App.Commands.Abstractions;
    using TeamBuilder.App.Interfaces;
    using TeamBuilder.Data;
    using TeamBuilder.Models;

    class InviteToTeamCommand : Command
    {
        private const string Success = "Team {0} invited {1}!";
        private const string AddedToTeam = "User {0} joined team {1}!";
        private const int ArgsExactLength = 2;

        private const string EntityDoesNotExistExceptionMessage = "Team or user does not exist!";
        private const string NotAllowedExceptionMessage = "Not allowed!";
        private const string InvitationAlreadySentExceptionMessage = "Invite is already sent!";
        private const string AlreadyMemberExceptionMessage = "User {0} is already member of team {1}!";

        public InviteToTeamCommand(string[] cmdArgs, IUserSession session) 
            : base(cmdArgs, session)
        {
        }

        // <teamName> <username>
        public override string Execute(TeamBuilderContext context)
        {
            base.MustBeLoggedIn();
            base.CmdArgsExactLengthValidation(ArgsExactLength);

            var teamName = this.CmdArgs[0];
            var username = this.CmdArgs[1];

            var invitedUser = this.GetUser(context, username);
            var team = this.GetTeam(context, teamName);

            // If user is already a member
            if (team.TeamUsers.Any(tu => tu.User.Id == invitedUser.Id))
            {
                throw new InvalidOperationException(string.Format(AlreadyMemberExceptionMessage, username, teamName));
            }

            // If current user is Team Creator
            if (team.CreatorId == this.Session.User.Id)
            {
                var mapping = new UserTeam();
                mapping.Team = team;
                mapping.User = invitedUser;

                context.UsersTeams.Add(mapping);
                context.SaveChanges();

                return string.Format(AddedToTeam, username, teamName);
            }

            // If the current user is not creator of the team nor part of it or user to invite is alredy a member
            if (team.TeamUsers.Any(tu => tu.UserId == invitedUser.Id) ||
                !team.TeamUsers.Any(tu => tu.UserId == this.Session.User.Id))
            {
                throw new InvalidOperationException(NotAllowedExceptionMessage);
            }

            // If already active invite exists
            if (context.Invitations.Any(i => i.TeamId == team.Id && 
                i.InvitedUserId == invitedUser.Id))
            {
                throw new InvalidOperationException(InvitationAlreadySentExceptionMessage);
            }

            // Add new Invitation
            var invitation = new Invitation();
            invitation.Team = team;
            invitation.InvitedUser = invitedUser;
            invitation.IsActive = true;

            context.Invitations.Add(invitation);
            context.SaveChanges();

            return string.Format(Success, teamName, username);
        }

        private Team GetTeam(TeamBuilderContext context, string teamName)
        {
            var team = context.Teams
                .Include(t => t.Creator)
                .Include(t => t.TeamUsers)
                .SingleOrDefault(t => t.Name.Equals(teamName, StringComparison.OrdinalIgnoreCase));

            if (team == null)
            {
                throw new ArgumentException(EntityDoesNotExistExceptionMessage);
            }

            return team;
        }

        private User GetUser(TeamBuilderContext context, string username)
        {
            var user = context.Users
                .SingleOrDefault(u => u.Username.Equals(username, StringComparison.OrdinalIgnoreCase));

            if (user == null)
            {
                throw new ArgumentException(EntityDoesNotExistExceptionMessage);
            }

            return user;
        }
    }
}
