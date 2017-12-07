namespace TeamBuilder.App.Commands
{
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Linq;
    using TeamBuilder.App.Commands.Abstractions;
    using TeamBuilder.App.Interfaces;
    using TeamBuilder.Data;
    using TeamBuilder.Models;

    public class KickMemberCommand : Command
    {
        private const string Success = "User {0} was kicked from {1}!";
        private const int ArgsExactLength = 2;

        private const string TeamDoesNotExistExceptionMessage = "Team {0} not found!";
        private const string UserNotFoundExistExceptionMessage = "User {0} not found!";
        private const string NotAllowedExistExceptionMessage = "Not allowed!";
        private const string NotAMemberExceptionMessage = "User {0} is not a member in {1}!";
        private const string KikCreatorExistExceptionMessage = "Command not allowed. Use DisbandTeam instead.";

        public KickMemberCommand(string[] cmdArgs, IUserSession session) 
            : base(cmdArgs, session)
        {
        }

        // <teamName> <username>
        public override string Execute(TeamBuilderContext context)
        {
            base.MustBeLoggedIn();
            base.CmdArgsExactLengthValidation(ArgsExactLength);

            var username = this.CmdArgs[1];
            var teamName = this.CmdArgs[0];

            if (this.Session.User.Username.Equals(username, StringComparison.OrdinalIgnoreCase))
            {
                throw new InvalidOperationException(NotAllowedExistExceptionMessage);
            }

            var user = this.AssureUserExists(context, username);
            var team = this.GetTeam(context, teamName, user);

            var mapping = team.TeamUsers.First();
            context.Remove(mapping);
            context.SaveChanges();

            return string.Format(Success, username, teamName);
        }

        private Team GetTeam(TeamBuilderContext context, string teamName, User user)
        {
            var team = context.Teams
                .Include(t => t.TeamUsers)
                .SingleOrDefault(t => t.Name.Equals(teamName, StringComparison.OrdinalIgnoreCase));

            if (team == null)
            {
                throw new ArgumentException(string.Format(TeamDoesNotExistExceptionMessage, teamName));
            }

            if (team.CreatorId != this.Session.User.Id)
            {
                throw new InvalidOperationException(KikCreatorExistExceptionMessage);
            }

            team.TeamUsers = team.TeamUsers
                .Where(tu => tu.UserId == user.Id)
                .ToList();

            if (team.TeamUsers == null || team.TeamUsers.Count == 0)
            {
                throw new ArgumentException(string.Format(NotAMemberExceptionMessage, user.Username, teamName));
            }

            return team;
        }

        private User AssureUserExists(TeamBuilderContext context, string username)
        {
            var user = context.Users
                .SingleOrDefault(u => u.Username.Equals(username, StringComparison.OrdinalIgnoreCase));

            if (user == null)
            {
                throw new ArgumentException(string.Format(UserNotFoundExistExceptionMessage, username));
            }

            return user;
        }
    }
}
