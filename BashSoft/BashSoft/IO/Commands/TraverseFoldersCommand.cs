namespace BashSoft.IO.Commands
{
    using Contracts;
    using Contracts.Repository;
    using Exceptions;

    public class TraverseFoldersCommand : Command
    {
        public TraverseFoldersCommand(string input, 
            string[] data, 
            IContentComparer judge, 
            IDatabase repository,
            IDirectoryManager inputOutputManager) 
                : base(input, data, judge, repository, inputOutputManager)
        {
        }

        public override void Execute()
        {
            if (this.Data.Length == 1)
            {
                this.InputOutputManager.TraverseDirectory(0);
            }
            else
            {
                int depth;
                var success = int.TryParse(this.Data[1], out depth);
                if (success)
                {
                    this.InputOutputManager.TraverseDirectory(depth);
                }
                else
                {
                    throw new InvalidNumberParseException();
                }
            }
        }
    }
}
