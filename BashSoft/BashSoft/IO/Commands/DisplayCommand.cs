namespace BashSoft.IO.Commands
{
    using System;
    using System.Collections.Generic;
    using Attributes;
    using Contracts;
    using Contracts.Repository;
    using Exceptions;

    [Alias(InitializingCommand)]
    internal class DisplayCommand : Command
    {
        private const string InitializingCommand = "display";

        [Inject]
        private IDatabase repository;

        public DisplayCommand(string input, string[] data) 
            : base(input, data)
        {
        }

        public override void Execute()
        {
            if (this.Data.Length != 3)
            {
                throw new InvalidCommandException(this.Input);
            }

            string entityToDisplay = this.Data[1];
            string sortType = this.Data[2];

            if (entityToDisplay.Equals("students", StringComparison.OrdinalIgnoreCase))
            {
                IComparer<IStudent> studentComparator = this.CreateStudentComparator(sortType);
                ISimpleOrderedBag<IStudent> list = this.repository.GetAllStudentsSorted(studentComparator);
                OutputWriter.WriteMessageOnNewLine(list.JoinWith(Environment.NewLine));
            }
            else if (entityToDisplay.Equals("courses", StringComparison.OrdinalIgnoreCase))
            {
                IComparer<ICourse> courseComparator = this.CreateCourseComparator(sortType);
                ISimpleOrderedBag<ICourse> list = this.repository.GetAllCoursesSorted(courseComparator);
                OutputWriter.WriteMessageOnNewLine(list.JoinWith(Environment.NewLine));
            }
            else
            {
                throw new InvalidCommandException(this.Input);
            }
        }

        private IComparer<ICourse> CreateCourseComparator(string sortType)
        {
            if (sortType.Equals("ascending", StringComparison.OrdinalIgnoreCase))
            {
                return Comparer<ICourse>.Create((first, second) => first.CompareTo(second));
            }

            if (sortType.Equals("descending", StringComparison.OrdinalIgnoreCase))
            {
                return Comparer<ICourse>.Create((first, second) => second.CompareTo(first));
            }

            throw new InvalidCommandException(this.Input);
        }

        private IComparer<IStudent> CreateStudentComparator(string sortType)
        {
            if (sortType.Equals("ascending", StringComparison.OrdinalIgnoreCase))
            {
                return Comparer<IStudent>.Create((studentOne, studentTwo) => studentOne.CompareTo(studentTwo));
            }

            if (sortType.Equals("descending", StringComparison.OrdinalIgnoreCase))
            {
                return Comparer<IStudent>.Create((studentOne, studentTwo) => studentTwo.CompareTo(studentOne));
            }

            throw new InvalidCommandException(this.Input);
        }
    }
}