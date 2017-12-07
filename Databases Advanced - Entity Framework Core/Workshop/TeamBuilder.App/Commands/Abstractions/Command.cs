namespace TeamBuilder.App.Commands.Abstractions
{
    using System;
    using TeamBuilder.App.Interfaces;
    using TeamBuilder.Data;

    public abstract class Command : ICommand
    {
        protected const string InvalidCommandArgsExceptionMessage = "Invalid arguments count!";
        private const string LogOutFirstExceptionMessage = "You should logout first!";
        private const string LogInFirstExceptionMessage = "You should login first!";

        public Command(string[] cmdArgs, IUserSession session)
        {
            this.CmdArgs = cmdArgs;
            this.Session = session;
        }

        public string[] CmdArgs { get; private set; }

        public IUserSession Session { get; set; }

        public abstract string Execute(TeamBuilderContext context);

        protected void CmdArgsExactLengthValidation(int argsExactLength)
        {
            if (this.CmdArgs == null || this.CmdArgs.Length != argsExactLength)
            {
                throw new FormatException(InvalidCommandArgsExceptionMessage);
            }
        }

        protected void CmdArgsMinLengthValidation(int minLength)
        {
            if (this.CmdArgs == null || this.CmdArgs.Length < minLength)
            {
                throw new FormatException(InvalidCommandArgsExceptionMessage);
            }
        }

        protected void MustBeLoggedOut()
        {
            if (this.Session.IsLoggedIn)
            {
                throw new InvalidOperationException(LogOutFirstExceptionMessage);
            }
        }

        protected void MustBeLoggedIn()
        {
            if (!this.Session.IsLoggedIn)
            {
                throw new InvalidOperationException(LogInFirstExceptionMessage);
            }
        }

        protected void AssignValueArgument<TModel>(TModel model, string errorMessage, Action<TModel> action)
        {
            try
            {
                action(model);
            }
            catch (ArgumentException)
            {
                throw new ArgumentException(errorMessage);
            }
        }
    }
}
