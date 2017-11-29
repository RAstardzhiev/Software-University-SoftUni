namespace PhotoShare.Client.Core.Commands
{
    using System;
    using System.Linq;
    using Microsoft.EntityFrameworkCore;
    using PhotoShare.Client.Core.Commands.AbstractCommands;
    using PhotoShare.Data;
    using PhotoShare.Models;
    using PhotoShare.Services.Interfaces;

    public class AcceptFriendCommand : UserSettingsCommand
    {
        private const string UserNotFoundExceptionMessage = "{0} not found!";
        private const string RequestNotFoundExceptionMessage = "{0} has not added {1} as a friend";
        private const string AlreadyFriendsExceptionMessage = "{0} is already a friend to {1}";

        private const string SuccessfulAcceptedFriend = "{0} accepted {1} as a friend";

        public AcceptFriendCommand(PhotoShareContext context, IUserSessionService userSession) 
            : base(context, userSession)
        {
        }

        // AcceptFriend <username1> <username2>
        public override string Execute(string[] data)
        {
            var acceptingUser = this.GetDetachedUser(data[0]);
            this.ProfileOwnerVerification(acceptingUser); // Can accept only requests to your profile
            var suggestingUser = this.GetDetachedUser(data[0]);
            var friendship = this.GetFriendship(acceptingUser, suggestingUser);

            friendship.IsAccepted = true;
            this.Context.SaveChanges();

            return string.Format(string.Format(SuccessfulAcceptedFriend, acceptingUser.Username, suggestingUser.Username));
        }

        private Friendship GetFriendship(User acceptingUser, User suggestingUser)
        {
            var friendship = this.Context.Friendships
                .SingleOrDefault(f => f.User.Id == suggestingUser.Id && f.Friend.Id == acceptingUser.Id);

            if (friendship == null)
            {
                throw new InvalidCastException(string.Format(RequestNotFoundExceptionMessage, suggestingUser.Username, acceptingUser.Username));
            }

            if (friendship.IsAccepted)
            {
                throw new InvalidCastException(string.Format(AlreadyFriendsExceptionMessage, suggestingUser.Username, acceptingUser.Username));
            }

            return friendship;
        }

        private User GetDetachedUser(string username)
        {
            var user = this.Context.Users
                .AsNoTracking()
                .SingleOrDefault(u => u.Username.Equals(username, StringComparison.OrdinalIgnoreCase));

            if (user == null)
            {
                throw new ArgumentException(string.Format(UserNotFoundExceptionMessage, username));
            }

            return user;
        }
    }
}
