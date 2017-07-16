namespace Minedraft.Models.Providers
{
    using System;
    using System.Text;

    public abstract class Provider : Identificator
    {
        private double energyOutput;

        protected Provider(string id, double energyOutput) : base(id)
        {
            this.Id = id;
            this.EnergyOutput = energyOutput;
        }

        public virtual double EnergyOutput
        {
            get
            {
                return this.energyOutput;
            }

            protected set
            {
                if (value < 0 || value > 10000)
                {
                    throw new ArgumentException($"Provider is not registered, because of it's {nameof(EnergyOutput)}");
                }

                this.energyOutput = value;
            }
        }

        public override string ToString()
        {
            var type = this.GetType().Name;

            var sb = new StringBuilder();
            sb.AppendLine($"{type.Substring(0, type.IndexOf("Provider"))} Provider - {this.Id}")
                .AppendLine($"Energy Output: {this.energyOutput}");

            return sb.ToString().Trim();
        }
    }
}