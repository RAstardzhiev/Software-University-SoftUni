namespace BashSoft.IO.Commands
{
    using Exceptions;

    public class CompareFilesCommand : Command
    {
        public CompareFilesCommand(string input, string[] data, Tester judge, StudentsRepository repository, IOManager inputOutputManager) 
            : base(input, data, judge, repository, inputOutputManager)
        {
        }

        public override void Execute()
        {
            if (this.Data.Length != 3)
            {
                throw new InvalidCommandException(this.Input);
            }

            string firstPath = this.Data[1];
            string secondPath = this.Data[2];
            this.Judge.CompareContent(firstPath, secondPath);
        }
    }
}
