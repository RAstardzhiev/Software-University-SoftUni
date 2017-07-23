namespace BashSoft.Execptions
{
    using System;

    public class InvalidPathException : Exception
    {
        private const string InvalidPath =
            "The folder/file you are trying to access at the current address, does not exist.";
        public InvalidPathException() : base(InvalidPath) { }
        public InvalidPathException(string message) : base(message) { }
    }
}
