namespace PhotoShare.Client.Core.Commands
{
    using System;
    using PhotoShare.Data;
    using PhotoShare.Client.Interfaces;

    public class ExitCommand : ICommand
    {
        private const string Message = "Bye-bye!";

        private IWriter writer;

        public ExitCommand(PhotoShareContext context, IWriter writer) 
        {
            this.writer = writer;
        }

        public string Execute(string[] data)
        {
            this.writer.WriteLine(Message);
            Environment.Exit(Environment.ExitCode);
            return Message;
        }
    }
}
