namespace _01.Harvesting_Fields_vs_Dictionary
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using System.Text;

    public class HarvestingFieldsTest
    {
        private StringBuilder sb;

        public HarvestingFieldsTest()
        {
            this.sb = new StringBuilder();
        }

        internal string Run()
        {
            var requestedMod = Console.ReadLine();
            var fields = typeof(HarvestingFields).GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);

            var accModFilters = new Dictionary<string, Func<IEnumerable<FieldInfo>>>()
            {
                { "private", () => fields.Where(f => f.IsPrivate) },
                { "protected", () => fields.Where(f => f.IsFamily) },
                { "public", () => fields.Where(f => f.IsPublic) },
                { "all", () => fields }
            };

            while (requestedMod != "HARVEST")
            {
                this.AppendFields(accModFilters[requestedMod]());
                requestedMod = Console.ReadLine();
            }

            return this.sb.ToString().Trim();
        }

        private void AppendFields(IEnumerable<FieldInfo> fieldsCollection)
        {
            foreach (var field in fieldsCollection)
            {
                var accessmodifier = field.Attributes.ToString().ToLower();
                if (accessmodifier.Equals("family"))
                {
                    accessmodifier = "protected";
                }

                this.sb.AppendLine($"{accessmodifier} {field.FieldType.Name} {field.Name}");
            }
        }
    }
}
