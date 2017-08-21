namespace BashSoft.IO.Commands
{
    using Attributes;
    using Contracts;
    using Exceptions;

    [Alias(InitializingCommand)]
    public class ChangePathAbsoluteCommand : Command
    {
        private const string InitializingCommand = "cdAbs";

        [Inject]
        private IDirectoryManager inputOutputManager;

        public ChangePathAbsoluteCommand(string input, string[] data) 
                : base(input, data)
        {
        }

        public override void Execute()
        {
            if (this.Data.Length != 2)
            {
                throw new InvalidCommandException(this.Input);
            }

            var absPath = this.Data[1];
            this.inputOutputManager.ChangeCurrentDirectoryAbsolute(absPath);
        }
    }
}
