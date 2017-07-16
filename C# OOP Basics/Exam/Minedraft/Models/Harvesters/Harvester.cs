namespace Minedraft.Models.Harvesters
{
    using System;
    using System.Text;

    public abstract class Harvester : Identificator
    {
        private double oreOutput;
        private double energyRequirement;

        protected Harvester(string id, double oreOutput, double energyRequirement) : base(id)
        {
            this.Id = id;
            this.OreOutput = oreOutput;
            this.EnergyRequirement = energyRequirement;
        }

        public double OreOutput
        {
            get
            {
                return this.oreOutput;
            }

            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentException($"Harvester is not registered, because of it's {nameof(this.OreOutput)}");
                }

                this.oreOutput = value;
            }
        }

        public double EnergyRequirement
        {
            get
            {
                return this.energyRequirement;
            }

            protected set
            {
                if (value < 0 || value > 20000)
                {
                    throw new ArgumentException($"Harvester is not registered, because of it's {nameof(EnergyRequirement)}");
                }

                this.energyRequirement = value;
            }
        }

        public override string ToString()
        {
            var type = this.GetType().Name;

            var sb = new StringBuilder();
            sb.AppendLine($"{type.Substring(0, type.IndexOf("Harvester"))} Harvester - {this.Id}")
                .AppendLine($"Ore Output: {this.oreOutput}")
                .AppendLine($"Energy Requirement: {this.energyRequirement}");

            return sb.ToString().Trim();
        }
    }
}
