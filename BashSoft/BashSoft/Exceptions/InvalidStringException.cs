namespace BashSoft.Exceptions
{
    using System;

    public class InvalidStringException : Exception
    {
        public InvalidStringException() : base(ExceptionMessages.NullOrEmptyValue)
        {
        }

        public InvalidStringException(string message) : base($"{message} {ExceptionMessages.NullOrEmptyValue}")
        {
        }
    }
}
