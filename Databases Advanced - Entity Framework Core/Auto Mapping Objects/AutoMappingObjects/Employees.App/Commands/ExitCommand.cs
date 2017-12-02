namespace Employees.App.Commands
{
    using Employees.App.Commands.Abstractions;
    using System;

    public class ExitCommand : Command
    {
        public ExitCommand(string[] cmdArgs) : base(cmdArgs)
        {
        }

        public override void Execute() => Environment.Exit(Environment.ExitCode);
    }
}
