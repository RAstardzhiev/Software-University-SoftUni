namespace _08.Military_Elite.Models.Soldiers.Privates
{
    using Interfaces;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class LeutenantGeneral : Private, ILeutenantGeneral
    {
        private List<IPrivate> privateSoldiers;

        public LeutenantGeneral(string id, string firstName, string lastName, double salary, IEnumerable<IPrivate> privateSoldiers) 
            : base(id, firstName, lastName, salary)
        {
            this.privateSoldiers = new List<IPrivate>(privateSoldiers);
        }

        public IReadOnlyList<IPrivate> PrivateSoldiers
        {
            get
            {
                return this.privateSoldiers as IReadOnlyList<IPrivate>;
            }
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine(base.ToString())
                .AppendLine("Privates:")
                .Append(string.Join($"  {Environment.NewLine}", this.PrivateSoldiers.Select(ps => $"  {ps.ToString()}")));

            return sb.ToString().Trim();
        }
    }
}
