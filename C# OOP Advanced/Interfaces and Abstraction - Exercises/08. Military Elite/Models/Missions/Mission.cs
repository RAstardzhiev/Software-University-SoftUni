namespace _08.Military_Elite.Models.Missions
{
    using Interfaces;
    using System;
    using System.Linq;

    public class Mission : IMission
    {
        private readonly string[] possibleStates = new string[] { "inProgress", "Finished" };

        private string codeName;
        private string state;

        public Mission(string codeName, string state)
        {
            this.codeName = codeName;
            this.State = state;
        }

        public string CodeName { get; private set; }

        public string State
        {
            get
            {
                return this.state;
            }

            set
            {
                if (!this.possibleStates.Contains(value))
                {
                    throw new ArgumentException("Invalid mission state");
                }

                this.state = value;
            }
        }

        public void CompleteMission()
        {
            this.state = "Finished";
        }

        public override string ToString()
        {
            return $"Code Name: {this.codeName} State: {this.State}";
        }
    }
}
