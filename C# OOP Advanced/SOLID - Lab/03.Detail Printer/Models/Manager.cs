namespace _03.Detail_Printer.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Manager : Employee
    {
        public Manager(string name, ICollection<string> documents) : base(name)
        {
            this.Documents = new List<string>(documents);
        }

        public IReadOnlyCollection<string> Documents { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine(this.Name)
                .AppendLine(string.Join(", ", this.Documents));

            return sb.ToString().Trim();
        }
    }
}
