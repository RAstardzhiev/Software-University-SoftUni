namespace _04.Online_Radio_Database
{
    using Exceptions;

    public class Song
    {
        private const int ArtistMinLength = 3;
        private const int ArtistMaxLength = 20;
        private const int NameMinLength = 3;
        private const int NameMaxLength = 30;
        private const int MinutesMin = 0;
        private const int MinutesMax = 14;
        private const int SecondsMin = 0;
        private const int SecondsMax = 59;

        private string artist;
        private string name;
        private int minutes;
        private int seconds;

        public Song(string artist, string name, int minutes, int seconds)
        {
            this.Artist = artist;
            this.Name = name;
            this.Minutes = minutes;
            this.Seconds = seconds;
        }

        private string Artist
        {
            set
            {
                if (value.Length < ArtistMinLength || value.Length > ArtistMaxLength)
                {
                    throw new InvalidArtistNameException(ArtistMinLength, ArtistMaxLength);
                }

                this.artist = value;
            }
        }

        private string Name
        {
            set
            {
                if (value.Length < NameMinLength || value.Length > NameMaxLength)
                {
                    throw new InvalidSongNameException(NameMinLength, NameMaxLength);
                }

                this.name = value;
            }
        }

        public int Minutes
        {
            get
            {
                return this.minutes;
            }

            private set
            {
                if (value < MinutesMin || value > MinutesMax)
                {
                    throw new InvalidSongMinutesException(MinutesMin, MinutesMax);
                }

                this.minutes = value;
            }
        }

        public  int Seconds
        {
            get
            {
                return this.seconds;
            }

            private set
            {
                if (value < SecondsMin || value > SecondsMax)
                {
                    throw new InvalidSongSecondsException(SecondsMin, SecondsMax);
                }

                this.seconds = value;
            }
        }
    }
}
