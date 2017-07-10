namespace BashSoft.Exceptions
{
    using System;
    public class InvalidCommandException : Exception
    {
        public InvalidCommandException(string command) : base($"The command {command} is invalid")
        {
        }
    }
}
