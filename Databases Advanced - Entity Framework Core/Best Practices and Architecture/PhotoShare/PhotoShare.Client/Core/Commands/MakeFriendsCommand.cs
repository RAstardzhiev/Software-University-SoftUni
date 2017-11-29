namespace PhotoShare.Client.Core.Commands
{
    using PhotoShare.Client.Interfaces;
    using PhotoShare.Data;
    using PhotoShare.Services.Interfaces;

    public class MakeFriendsCommand : ICommand
    {
        /*
         * Due to Ambiguous Requirement add this command to forward to the AddFriendCommand
         */

        private PhotoShareContext context;
        private IUserSessionService userSession;

        public MakeFriendsCommand(PhotoShareContext context, IUserSessionService userSession) 
        {
            this.context = context;
            this.userSession = userSession;
        }

        public string Execute(string[] data)
            => new AddFriendCommand(this.context, userSession).Execute(data);
    }
}
