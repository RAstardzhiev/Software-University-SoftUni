namespace P03_FootballBetting.Data.Models
{
    using System.Collections.Generic;

    public class PlayerStatistic
    {
        public int GameId { get; set; }
        public Game Game { get; set; }

        public int PlayerId { get; set; }
        public Player Player { get; set; }

        public int ScoredGoals { get; set; }

        public int Assists { get; set; } // Judge - is int

        public int MinutesPlayed { get; set; }

        public ICollection<Player> Players { get; set; }

        public ICollection<Game> Games { get; set; }
    }
}
