namespace BashSoft.IO.Commands
{
    using Attributes;
    using Contracts;
    using Exceptions;

    [Alias(InitializingCommand)]
    public class CompareFilesCommand : Command
    {
        private const string InitializingCommand = "cmp";

        [Inject]
        private IContentComparer judge;

        public CompareFilesCommand(string input, string[] data) 
            : base(input, data)
        {
        }

        public override void Execute()
        {
            if (this.Data.Length != 3)
            {
                throw new InvalidCommandException(this.Input);
            }

            this.judge.CompareContent(this.Data[1], this.Data[2]);
        }
    }
}
