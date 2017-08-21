namespace BashSoft.IO.Commands
{
    using Attributes;
    using Contracts.Repository;
    using Exceptions;

    [Alias(InitializingCommand)]
    public class ReadDatabaseFromFileCommand : Command
    {
        private const string InitializingCommand = "readDb";

        [Inject]
        private IDatabase repository;

        public ReadDatabaseFromFileCommand(string input, string[] data) 
            : base(input, data)
        {
        }

        public override void Execute()
        {
            if (this.Data.Length != 2)
            {
                throw new InvalidCommandException(this.Input);
            }

            var databasePath = this.Data[1];
            this.repository.LoadData(databasePath);
        }
    }
}
