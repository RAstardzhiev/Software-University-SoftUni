namespace BashSoft.Execptions
{
    using System;

    public class InvalidNumberParseException : Exception
    {
        public const string UnableToParseNumber = "The sequence you've written is not a valid number.";

        public InvalidNumberParseException() : base(UnableToParseNumber) { }
        public InvalidNumberParseException(string message) : base(message) { }
    }
}
