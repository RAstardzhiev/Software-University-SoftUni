namespace _04.Online_Radio_Database.Exceptions
{
    public class InvalidSongSecondsException : InvalidSongLengthException
    {
        public InvalidSongSecondsException() : base()
        {
        }

        public InvalidSongSecondsException(string message) : base(message)
        {
        }

        public InvalidSongSecondsException(int minSongSeconds, int maxSongSeconds) 
            : base($"Song seconds should be between {minSongSeconds} and {maxSongSeconds}.")
        {
        }
    }
}
