namespace _04.Online_Radio_Database.Exceptions
{
    public class InvalidSongNameException : InvalidSongException
    {
        public InvalidSongNameException() : base()
        {
        }

        public InvalidSongNameException(string message) : base(message)
        {
        }

        public InvalidSongNameException(int minNameLength, int maxNameLength)
            : base($"Song name should be between {minNameLength} and {maxNameLength} symbols.")
        {
        }
    }
}
