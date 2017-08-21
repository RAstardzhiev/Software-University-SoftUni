namespace BashSoft.IO.Commands
{
    using Attributes;
    using Contracts;
    using Exceptions;

    [Alias(InitializingCommand)]
    public class ChangePathRelativelyCommand : Command
    {
        private const string InitializingCommand = "cdRel";

        [Inject]
        private IDirectoryManager inputOutputManager;

        public ChangePathRelativelyCommand(string input, string[] data) 
                : base(input, data)
        {
        }

        public override void Execute()
        {
            if (this.Data.Length != 2)
            {
                throw new InvalidCommandException(this.Input);
            }

            var relPath = this.Data[1];
            this.inputOutputManager.ChangeCurrentDirectoryRelative(relPath);
        }
    }
}
