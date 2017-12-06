namespace TeamBuilder.App.Core
{
    using TeamBuilder.App.Interfaces;
    using TeamBuilder.Models;

    public class UserSession : IUserSession
    {
        public User User { get; set; }

        public bool IsLoggedIn => this.User != null;

        public void LogIn(User user) => this.User = user;

        public void LogOut() => this.User = null;
    }
}
