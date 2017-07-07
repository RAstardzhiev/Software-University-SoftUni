namespace _04.Online_Radio_Database.Exceptions
{
    public class InvalidSongLengthException : InvalidSongException
    {
        private const string Message = "Invalid song length.";

        public InvalidSongLengthException() : base(Message)
        {
        }

        public InvalidSongLengthException(string message) : base(message)
        {
        }
    }
}
