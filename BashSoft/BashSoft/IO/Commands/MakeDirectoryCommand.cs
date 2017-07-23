namespace BashSoft.IO.Commands
{
    using Execptions;
    using Contracts;

    public class MakeDirectoryCommand : Command
    {
        public MakeDirectoryCommand(string input, string[] data, Tester judge, StudentsRepository repository,
            IDirectoryManager inputOutputManager) : base(input, data, judge, repository, inputOutputManager)
        {
        }

        public override void Execute()
        {
            if (this.Data.Length != 2)
            {
                throw new InvalidCommandException(this.Input);
            }

            var folderName = this.Data[1];
            base.InputOutputManager.CreateDirectoryInCurrentFolder(folderName);
        }
    }
}
