namespace PhotoShare.Services
{
    using System;
    using Interfaces;
    using PhotoShare.Data;
    using PhotoShare.Models;
    using System.Linq;

    public class UserSessionService : IUserSessionService
    {
        private const string AuthorizationFailedExceptionMessage = "You have to LogIn first!";
        private const string FailedLoginExceptionMessage = "Invalid username or password!";
        private const string AlreadyLoggedInExceptionMessage = "You should logout first!";
        private const string AnonimousLogOutExceptionMessage = "You should log in first in order to logout.";

        private const string SuccessfulLogOut = "User {0} successfully logged out!";

        private const int MinutesSinceLastActivityToLogout = 30;
        
        private PhotoShareContext context;
        private User user;
        private DateTime? lastTimeOnline;

        public UserSessionService(PhotoShareContext context)
        {
            this.context = context;
        }

        public User User
        {
            get
            {
                if (this.user != null)
                {
                    var timeSpan = this.lastTimeOnline - DateTime.Now;
                    if (timeSpan.Value.Minutes > MinutesSinceLastActivityToLogout)
                    {
                        this.user = null;
                    }
                    else
                    {
                        this.lastTimeOnline = DateTime.Now;
                    }
                }

                return this.user;
            }

            private set
            {
                this.user = value;
                this.lastTimeOnline = DateTime.Now;
            }
        }

        public bool IsLoggedIn => this.User != null;
        
        public User Login(string username, string password)
        {
            if (this.IsLoggedIn)
            {
                throw new ArgumentException(AlreadyLoggedInExceptionMessage);
            }

            this.User = context.Users
                .SingleOrDefault(u => u.Username == username && u.Password == password);

            if (this.User == null)
            {
                throw new ArgumentException(FailedLoginExceptionMessage);
            }

            return this.User;
        }

        public string Logout()
        {
            if (!this.IsLoggedIn)
            {
                throw new InvalidCastException(AnonimousLogOutExceptionMessage);
            }

            var username = this.user.Username;
            this.User = null;

            return string.Format(SuccessfulLogOut, username);
        }

        public void Authorize()
        {
            if (!this.IsLoggedIn)
            {
                throw new InvalidOperationException(AuthorizationFailedExceptionMessage);
            }
        }
    }
}
