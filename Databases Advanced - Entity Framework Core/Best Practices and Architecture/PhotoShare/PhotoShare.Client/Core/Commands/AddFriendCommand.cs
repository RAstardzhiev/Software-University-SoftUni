namespace PhotoShare.Client.Core.Commands
{
    using System;
    using System.Linq;
    using PhotoShare.Data;
    using PhotoShare.Models;
    using PhotoShare.Client.Core.Commands.AbstractCommands;
    using PhotoShare.Services.Interfaces;

    public class AddFriendCommand : UserSettingsCommand
    {
        private const string UserNotFoundExceptionMessage = "User {0} not found!";
        private const string SelfRequestExceptionMessage = "Can not request friendship from yourself! :)";
        private const string RequestToAFriendExceptionMessage = "{0} is already a friend to {1}";
        private const string DuplicateFriendRequestExceptionMessage = "There is already sent a friend request between {0} and {1}. It is waiting for approval.";

        private const string SuccessfulRequest = "{0} sent a friend request to {1}";

        public AddFriendCommand(PhotoShareContext context, IUserSessionService userSession) 
            : base(context, userSession)
        {
        }

        // AddFriend <username1> <username2>
        public override string Execute(string[] data)
        {
            var requestSender = this.GetUser(data[0]);
            this.ProfileOwnerVerification(requestSender); // Can add friends only to your profile
            var requestReceiver = this.GetUser(data[1]);
            if (requestSender.Id == requestReceiver.Id)
            {
                throw new InvalidOperationException(SelfRequestExceptionMessage);
            }

            this.CheckCurrentFriendshipStatus(requestSender, requestReceiver);

            this.Context.Friendships.Add(new Friendship(requestSender, requestReceiver));
            this.Context.SaveChanges();
            return string.Format(SuccessfulRequest, requestSender.Username, requestReceiver.Username);
        }

        private void CheckCurrentFriendshipStatus(User requestSender, User requestReceiver)
        {
            var status = this.Context.Friendships
                .SingleOrDefault(f =>
                    (f.Friend.Id == requestReceiver.Id && f.User.Id == requestSender.Id) ||
                    (f.Friend.Id == requestSender.Id && f.User.Id == requestReceiver.Id));

            if (status != null)
            {
                if (!status.IsAccepted)
                {
                    throw new InvalidOperationException(string.Format(DuplicateFriendRequestExceptionMessage, requestSender.Username, requestReceiver.Username));
                }

                throw new InvalidOperationException(string.Format(RequestToAFriendExceptionMessage, requestReceiver.Username, requestSender.Username));
            }
        }

        private User GetUser(string username)
        {
            var user = this.Context.Users
                .SingleOrDefault(u => u.Username.Equals(username, StringComparison.OrdinalIgnoreCase));

            if (user == null)
            {
                throw new ArgumentException(string.Format(UserNotFoundExceptionMessage, username));
            }

            return user;
        }
    }
}
