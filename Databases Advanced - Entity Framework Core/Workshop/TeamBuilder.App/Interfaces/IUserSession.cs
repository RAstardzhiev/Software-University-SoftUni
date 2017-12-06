namespace TeamBuilder.App.Interfaces
{
    using TeamBuilder.Models;

    public interface IUserSession
    {
        User User { get; }

        bool IsLoggedIn { get; }

        void LogIn(User user);

        void LogOut();
    }
}
