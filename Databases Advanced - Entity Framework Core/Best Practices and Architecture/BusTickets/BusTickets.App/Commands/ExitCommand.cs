namespace BusTickets.App.Commands
{
    using BusTickets.App.Commands.Abstractions;
    using BusTickets.Data;
    using System;

    public class ExitCommand : Command
    {
        public ExitCommand(string[] cmdArgs) 
            : base(cmdArgs)
        {
        }

        public override string Execute(BusTicketsContext context)
        {
            Environment.Exit(Environment.ExitCode);
            return string.Empty;
        }
    }
}
