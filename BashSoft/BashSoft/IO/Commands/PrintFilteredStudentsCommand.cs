namespace BashSoft.IO.Commands
{
    using Exceptions;

    class PrintFilteredStudentsCommand : Command
    {
        public PrintFilteredStudentsCommand(string input, string[] data, Tester judge, StudentsRepository repository, IOManager inputOutputManager) : base(input, data, judge, repository, inputOutputManager)
        {
        }

        public override void Execute()
        {
            if (this.Data.Length != 5)
            {
                throw new InvalidCommandException(this.Input);
            }

            string courseName = this.Data[1];
            string filter = this.Data[2];
            string takeCommand = this.Data[3].ToLower();
            string takeQuantity = this.Data[4].ToLower();

            ParseParametersForFilterAndTake(takeCommand, takeQuantity, courseName, filter);
        }

        private void ParseParametersForFilterAndTake(string takeCommand, string takeQuantity, string courseName, string filter)
        {
            if (takeCommand != "take")
            {
                throw new InvalidCommandException(takeCommand);
            }

            if (takeQuantity == "all")
            {
                this.Repository.FilterAndTake(courseName, filter);
            }
            else
            {
                int studentsToTake;
                bool hasParsed = int.TryParse(takeQuantity, out studentsToTake);

                if (hasParsed)
                {
                    this.Repository.FilterAndTake(courseName, filter, studentsToTake);
                }
                else
                {
                    throw new InvalidCommandException(takeQuantity);
                }
            }
        }
    }
}
