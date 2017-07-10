namespace BashSoft.IO.Commands
{
    using Exceptions;
    using System.Diagnostics;

    public class OpenFileCommand : Command
    {
        public OpenFileCommand(string input, string[] data, Tester judge, StudentsRepository repository, IOManager inputOutputManager) 
            : base(input, data, judge, repository, inputOutputManager)
        {
        }

        public override void Execute()
        {
            if (this.Data.Length != 2)
            {
                throw new InvalidCommandException(this.Input);
            }

            string fileName = this.Data[1];

            // Open files with their default program
            Process.Start($"{SessionData.currentPath}\\{fileName}");
        }
    }
}
