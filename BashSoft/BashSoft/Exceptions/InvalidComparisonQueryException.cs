namespace BashSoft.Exceptions
{
    using System;

    public class InvalidComparisonQueryException : Exception
    {
        public const string InvalidComparisonQuery = "The comparison query you want, does not exist in the context of the current program!";

        public InvalidComparisonQueryException() : base(InvalidComparisonQuery)
        {
        }

        public InvalidComparisonQueryException(string message) : base(message)
        {
        }
    }
}
