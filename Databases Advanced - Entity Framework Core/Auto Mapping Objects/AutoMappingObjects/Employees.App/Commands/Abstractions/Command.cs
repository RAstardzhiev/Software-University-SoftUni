namespace Employees.App.Commands.Abstractions
{
    using Interfaces;

    public abstract class Command : ICommand
    {
        protected const string InvalidCommandArgumentsExceptionMessage = "Invalid command arguments!";

        protected Command(string[] cmdArgs)
        {
            CmdArgs = cmdArgs;
        }

        public string[] CmdArgs { get; set; }

        public abstract void Execute();
    }
}
