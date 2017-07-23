namespace BashSoft.Exceptions
{
    using System;
    public class InvalidFileNameException : Exception
    {
        private const string ForbiddenSymbolsContainedInName =
            "The given name contains symbols that are not allowed to be used in names of files and folders.";
        public InvalidFileNameException() : base(ForbiddenSymbolsContainedInName) { }
        public InvalidFileNameException(string message) : base(message) { }
    }
}
