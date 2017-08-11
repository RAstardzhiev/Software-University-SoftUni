namespace BashSoft.Exceptions
{
    using System;

    public class InvalidTakeQueryParamterException : Exception
    {
        private const string InvalidTakeQueryParamter = 
            "The take command expected does not match the format wanted!";

        public InvalidTakeQueryParamterException() 
            : base(InvalidTakeQueryParamter)
        {
        }

        public InvalidTakeQueryParamterException(string message) 
            : base(message)
        {
        }
    }
}
