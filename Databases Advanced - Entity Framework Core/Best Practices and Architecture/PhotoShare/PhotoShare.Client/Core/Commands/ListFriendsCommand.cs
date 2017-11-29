namespace PhotoShare.Client.Core.Commands
{
    using System;
    using System.Linq;
    using PhotoShare.Data;
    using PhotoShare.Client.Interfaces;

    public class ListFriendsCommand : ICommand
    {
        private const string UserNotFoundExceptionMessage = "User {0} not found!";

        private const string NoOneFriendFound = "No friends for this user. :(";
        private readonly string FriendsListTitle = $"Friends: {Environment.NewLine}- ";

        private PhotoShareContext context;

        public ListFriendsCommand(PhotoShareContext context)
        {
            this.context = context;
        }

        // ListFriends <username>
        public string Execute(string[] data)
        {
            var username = data[0];
            var user = this.context.Users
                .Select(u => new
                {
                    u.Username,
                    AddedAsFriendBy = u.AddedAsFriendBy
                        .Select(f => f.User.Username)
                        .ToArray(),
                    FriendsAdded = u.FriendsAdded
                        .Select(f => f.Friend.Username)
                        .ToArray()
                })
                .SingleOrDefault(u => u.Username.Equals(username, StringComparison.OrdinalIgnoreCase));

            if (user == null)
            {
                throw new ArgumentException(string.Format(UserNotFoundExceptionMessage, username));
            }

            var friends = user.AddedAsFriendBy
                .Concat(user.FriendsAdded);

            return friends.Any() 
                ? FriendsListTitle + string.Join($"{Environment.NewLine}- ", friends)
                : NoOneFriendFound;
        }
    }
}
