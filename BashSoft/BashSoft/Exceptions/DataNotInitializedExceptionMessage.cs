namespace BashSoft.Exceptions
{
    using System;

    public class DataNotInitializedExceptionMessage : Exception
    {
        public const string DataNotInitializedMessage = "The data structure must be initialised first in order to make any operations with it.";

        public DataNotInitializedExceptionMessage() : base(DataNotInitializedMessage)
        {
        }

        public DataNotInitializedExceptionMessage(string message) : base(message)
        {
        }
    }
}
