namespace Avatar___12_July_2017.Models
{
    using Benders;
    using Monuments;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Nation
    {
        private string type;
        private List<Bender> benders;
        private List<Monument> monuments;

        public Nation(string type)
        {
            this.type = type;
            this.benders = new List<Bender>();
            this.monuments = new List<Monument>();
        }

        public void AddBender(Bender bender)
        {
            this.benders.Add(bender);
        }

        public double GetTotalPower()
        {
            var totalPower = this.benders
                .Select(b => b.GetTotalPower())
                .Sum();

            var monumentsAffinitySum = this.monuments
                .Select(m => m.GetAffinity())
                .Sum();

            var bonus = monumentsAffinitySum / 100 * totalPower;
            return totalPower + bonus;
        }

        public void AddMonument(Monument monument)
        {
            this.monuments.Add(monument);
        }

        public void RemoveResources()
        {
            this.monuments.Clear();
            this.benders.Clear();
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"{this.type} Nation");

            if (this.benders.Count == 0)
            {
                sb.AppendLine("Benders: None");
            }
            else
            {
                sb.AppendLine("Benders:")
                    .AppendLine(string.Join(Environment.NewLine, this.benders
                        .Select(b => $"###{this.type} Bender: {b.ToString()}")));
            }

            if (this.monuments.Count == 0)
            {
                sb.AppendLine("Monuments: None");
            }
            else
            {
                sb.AppendLine("Monuments:")
                    .AppendLine(string.Join(Environment.NewLine, this.monuments
                        .Select(m => $"###{this.type} Monument: {m.ToString()}")));
            }

            return sb.ToString().Trim();
        }
    }
}
