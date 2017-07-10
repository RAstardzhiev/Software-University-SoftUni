namespace BashSoft.IO.Commands
{
    using Exceptions;

    public class PrintOrderedStudentsCommand : Command
    {
        public PrintOrderedStudentsCommand(string input, string[] data, Tester judge, StudentsRepository repository, IOManager inputOutputManager)
            : base(input, data, judge, repository, inputOutputManager)
        {
        }

        public override void Execute()
        {
            if (this.Data.Length != 5)
            {
                throw new InvalidCommandException(this.Input);
            }

            string courseName = this.Data[1];
            string comparison = this.Data[2];
            string orderCommand = this.Data[3].ToLower();
            string takeQuantity = this.Data[4].ToLower();

            ParseParametersForOrderAndTake(orderCommand, takeQuantity, courseName, comparison);
        }

        private void ParseParametersForOrderAndTake(string orderCommand, string takeQuantity, string courseName, string comparison)
        {
            if (orderCommand != "order")
            {
                throw new InvalidCommandException(orderCommand);
            }

            if (takeQuantity == "all")
            {
                this.Repository.OrderAndTake(courseName, comparison);
            }
            else
            {
                int studentsToTake;
                bool hasParsed = int.TryParse(takeQuantity, out studentsToTake);

                if (hasParsed)
                {
                    this.Repository.OrderAndTake(courseName, comparison, studentsToTake);
                }
                else
                {
                    throw new InvalidCommandException(takeQuantity);
                }
            }
        }
    }
}
