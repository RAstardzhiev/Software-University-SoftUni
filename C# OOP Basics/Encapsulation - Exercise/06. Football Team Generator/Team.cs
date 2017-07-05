namespace _06.Football_Team_Generator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Team
    {
        private string name;
        private HashSet<Player> players;

        public Team(string name)
        {
            this.Name = name;
            this.players = new HashSet<Player>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            private set
            {
                if (string.IsNullOrWhiteSpace(value) || value == string.Empty)
                {
                    throw new ArgumentException("A name should not be empty.");
                }

                this.name = value;
            }
        }

        public double GetRating()
        {
            if (this.players.Count > 0)
            {
                return this.players.Select(p => p.SkillLevel).Average();
            }
            else
            {
                return 0;
            }
        }

        internal void AddPlayer(Player player)
        {
            this.players.Add(player);
        }

        internal bool IsPlayerFound(string playerName)
        {
            return this.players.FirstOrDefault(p => p.Name == playerName) != null;
        }

        internal void RemovePlayer(string playerName)
        {
            if (this == null)
            {
                throw new NullReferenceException("Team does not existent");
            }

            if (this.players.Any(p => p.Name == playerName))
            {
                this.players.RemoveWhere(p => p.Name == playerName);
            }
            else
            {
                throw new InvalidOperationException($"Player {playerName} is not in {this.Name} team.");
            }
        }
    }
}
