namespace BashSoft.IO.Commands
{
    using Attributes;
    using Contracts.Repository;
    using Exceptions;

    [Alias(InitializingCommand)]
    public class DropDbCommand : Command
    {
        private const string InitializingCommand = "dropdb";
        private const string ExecutionMessage = "Database dropped!";

        [Inject]
        private IDatabase repository;

        public DropDbCommand(string input, string[] data) 
            : base(input, data)
        {
        }

        public override void Execute()
        {
            if (this.Data.Length != 1)
            {
                throw new InvalidCommandException(this.Input);
            }

            this.repository.UnloadData();
            OutputWriter.WriteMessageOnNewLine(ExecutionMessage);
        }
    }
}
