namespace BashSoft.Exceptions
{
    using System;

    public class InvalidStudentFilterException : Exception
    {
        public const string InvalidStudentFilter = "The given filter is not one of the following: excellent/average/poor.";

        public InvalidStudentFilterException() : base(InvalidStudentFilter)
        {
        }

        public InvalidStudentFilterException(string message) : base(message)
        {
        }
    }
}
