namespace BashSoft.IO.Commands
{
    using Exceptions;

    public class ChangeAbsolutePathCommand : Command
    {
        public ChangeAbsolutePathCommand(string input, string[] data, Tester judge, StudentsRepository repository, IOManager inputOutputManager) 
            : base(input, data, judge, repository, inputOutputManager)
        {
        }

        public override void Execute()
        {
            if (this.Data.Length != 2)
            {
                throw new InvalidCommandException(this.Input);
            }

            string absolutePath = this.Data[1];
            this.InputOutputManager.ChangeCurrentDirectoryAbsolute(absolutePath);
        }
    }
}
