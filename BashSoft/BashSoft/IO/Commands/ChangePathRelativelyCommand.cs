namespace BashSoft.IO.Commands
{
    using Contracts;
    using Execptions;

    public class ChangePathRelativelyCommand : Command
    {
        public ChangePathRelativelyCommand(string input, string[] data, Tester judge, StudentsRepository repository,
            IDirectoryManager inputOutputManager) : base(input, data, judge, repository, inputOutputManager) { }

        public override void Execute()
        {
            if (this.Data.Length != 2)
            {
                throw new InvalidCommandException(this.Input);
            }

            var relPath = this.Data[1];
            this.InputOutputManager.ChangeCurrentDirectoryRelative(relPath);
        }
    }
}
