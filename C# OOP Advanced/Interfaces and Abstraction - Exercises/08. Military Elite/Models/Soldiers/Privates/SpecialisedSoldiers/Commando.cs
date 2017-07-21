namespace _08.Military_Elite.Models.Soldiers.Privates.SpecialisedSoldiers
{
    using Interfaces;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Commando : SpecialisedSoldier, ICommando
    {
        private IList<IMission> missions;

        public Commando(string id, string firstName, string lastName, double salary, string corps, IEnumerable<IMission> missions) 
            : base(id, firstName, lastName, salary, corps)
        {
            this.missions = new List<IMission>(missions);
        }

        public IReadOnlyList<IMission> Missions
        {
            get
            {
                return this.missions as IReadOnlyList<IMission>;
            }
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine(base.ToString())
                .AppendLine("Missions:")
                .Append("  ")
                .Append(string.Join($"  {Environment.NewLine}", this.missions.Select(m => $"  {m.ToString()}")));

            return sb.ToString().Trim();
        }
    }
}
