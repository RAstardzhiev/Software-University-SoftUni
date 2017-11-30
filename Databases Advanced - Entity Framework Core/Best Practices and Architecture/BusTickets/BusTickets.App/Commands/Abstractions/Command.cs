namespace BusTickets.App.Commands.Abstractions
{
    using BusTickets.Data;
    using Interfaces;

    public abstract class Command : ICommand
    {
        protected const string InvalidCommandArgsExceptionMessage = "Invalid command arguments!";

        public Command(string[] cmdArgs)
        {
            this.CmdArgs = cmdArgs;
        }

        public string[] CmdArgs { get; private set; }

        public abstract string Execute(BusTicketsContext context);
    }
}
