namespace PhotoShare.Client.Core.Commands
{
    using PhotoShare.Client.Interfaces;
    using PhotoShare.Services.Interfaces;

    public class LogOutCommand : ICommand
    {
        private IUserSessionService userSession;

        public LogOutCommand(IUserSessionService userSession)
        {
            this.userSession = userSession;
        }

        public string Execute(string[] data) => this.userSession.Logout();
    }
}
