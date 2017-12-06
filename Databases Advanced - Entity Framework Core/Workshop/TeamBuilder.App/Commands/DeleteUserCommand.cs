namespace TeamBuilder.App.Commands
{
    using Microsoft.EntityFrameworkCore;
    using TeamBuilder.App.Commands.Abstractions;
    using TeamBuilder.App.Interfaces;
    using TeamBuilder.Data;

    public class DeleteUserCommand : Command
    {
        private const string Success = "User {0} was deleted successfully!";

        public DeleteUserCommand(string[] cmdArgs, IUserSession session) 
            : base(cmdArgs, session)
        {
        }

        public override string Execute(TeamBuilderContext context)
        {
            base.MustBeLoggedIn();

            context.Entry(this.Session.User).State = EntityState.Unchanged;
            this.Session.User.IsDeleted = true;
            context.SaveChanges();

            var username = this.Session.User.Username;
            this.Session.LogOut();

            return string.Format(Success, username);
        }
    }
}
