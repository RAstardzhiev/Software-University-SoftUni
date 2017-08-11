namespace BashSoft.IO.Commands
{
    using Contracts;
    using Contracts.Repository;
    using Exceptions;

    public class DropDbCommand : Command
    {
        public DropDbCommand(string input, 
            string[] data, 
            IContentComparer judge, 
            IDatabase repository, 
            IDirectoryManager inputOutputManager) 
                : base(input, data, judge, repository, inputOutputManager)
        {
        }

        public override void Execute()
        {
            if (this.Data.Length != 1)
            {
                throw new InvalidCommandException(this.Input);
            }

            this.Repository.UnloadData();
            OutputWriter.WriteMessageOnNewLine("Database dropped!");
        }
    }
}
