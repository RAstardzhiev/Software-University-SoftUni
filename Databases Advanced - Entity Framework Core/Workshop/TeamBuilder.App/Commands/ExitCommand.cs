namespace TeamBuilder.App.Commands
{
    using System;
    using TeamBuilder.App.Commands.Abstractions;
    using TeamBuilder.App.Interfaces;
    using TeamBuilder.Data;

    public class ExitCommand : Command
    {
        public ExitCommand(string[] cmdArgs, IUserSession session) 
            : base(cmdArgs, session)
        {
        }

        public override string Execute(TeamBuilderContext context)
        {
            Environment.Exit(Environment.ExitCode);
            return string.Empty;
        }
    }
}
