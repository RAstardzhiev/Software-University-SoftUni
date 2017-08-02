namespace _01.Harvesting_Fields
{
    using System;
    using System.Text;
    using System.Reflection;
    using System.Linq;
    using System.Collections.Generic;

    public class HarvestingFieldsTest
    {
        private StringBuilder sb;

        public HarvestingFieldsTest()
        {
            this.sb = new StringBuilder();
        }

        internal string Run()
        {
            var command = Console.ReadLine();
            var type = typeof(HarvestingFields);

            while (command != "HARVEST")
            {
                switch (command)
                {
                    case "private":
                        this.AppendFields(type.GetFields(BindingFlags.Instance | BindingFlags.NonPublic)
                            .Where(f => f.IsPrivate));
                        break;
                    case "protected":
                        this.AppendFields(type.GetFields(BindingFlags.Instance | BindingFlags.NonPublic)
                            .Where(f => f.IsFamily));
                        break;
                    case "public":
                        this.AppendFields(type.GetFields(BindingFlags.Instance | BindingFlags.Public));
                        break;
                    case "all":
                        this.AppendFields(type.GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
                        break;
                    default:
                        break;
                }

                command = Console.ReadLine();
            }

            return sb.ToString().Trim();
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

                sb.AppendLine($"{accessmodifier} {field.FieldType.Name} {field.Name}");
            }
        }
    }
}
