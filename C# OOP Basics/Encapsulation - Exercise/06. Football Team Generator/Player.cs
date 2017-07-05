namespace _06.Football_Team_Generator
{
    using System;

    public class Player
    {
        private const int MinStatsValue = 0;
        private const int MaxStatsValue = 100;

        private string name;
        private double endurance;
        private double sprint;
        private double dribble;
        private double passing;
        private double shooting;
        private double skillLevel;

        public Player(string name, double endurance, double sprint, double dribble, double passing, double shooting)
        {
            this.Name = name;
            this.Endurance = endurance;
            this.Sprint = sprint;
            this.Dribble = dribble;
            this.Passing = passing;
            this.Shooting = shooting;
            this.skillLevel = (endurance + sprint + dribble + passing + shooting) / 5;
        }

        public double SkillLevel { get { return this.skillLevel; } }

        private double Shooting
        {
            set
            {
                ValidateStat(value, nameof(Shooting));
                this.shooting = value;
            }
        }

        private double Passing
        {
            set
            {
                ValidateStat(value, nameof(Passing));
                this.passing = value;
            }
        }

        private double Dribble
        {
            set
            {
                ValidateStat(value, nameof(Dribble));
                this.dribble = value;
            }
        }

        private double Sprint
        {
            set
            {
                ValidateStat(value, nameof(Sprint));
                this.sprint = value;
            }
        }

        private double Endurance
        {
            set
            {
                ValidateStat(value, nameof(Endurance));
                this.endurance = value;
            }
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

        private void ValidateStat(double stat, string propertyName)
        {
            if (stat < MinStatsValue || stat > MaxStatsValue)
            {
                throw new ArgumentException($"{propertyName} should be between 0 and 100.");
            }
        }
    }
}
