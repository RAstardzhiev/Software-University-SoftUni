namespace Query_Mess
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class QueryMess
    {
        public static void Main(string[] args)
        {
            string query = Console.ReadLine();

            while (!query.ToLower().Equals("end"))
            {
                Dictionary<string, List<string>> fieldValue = new Dictionary<string, List<string>>();
                ExtractQueryData(fieldValue, query.Split('&'));

                Console.WriteLine(string.Join(string.Empty, fieldValue
                    .Select(x => $"{x.Key}=[{string.Join(", ", x.Value)}]")));

                query = Console.ReadLine();
            }
        }

        private static void ExtractQueryData(Dictionary<string, List<string>> fieldValue, string[] nameValue)
        {
            for (int i = 0; i < nameValue.Length; i++)
            {
                int equalSeparator = nameValue[i].IndexOf('=');
                string name = ClearGarbage(nameValue[i].Substring(0, equalSeparator));
                string value = ClearGarbage(nameValue[i].Substring(equalSeparator + 1));

                if (!fieldValue.ContainsKey(name))
                {
                    fieldValue[name] = new List<string>();
                }

                fieldValue[name].Add(value);
            }
        }

        private static string ClearGarbage(string dirty)
        {
            if (dirty.Contains('?'))
            {
                dirty = dirty.Substring(dirty.LastIndexOf('?') + 1);
            }

            return string.Join(" ", dirty
                .Replace('+', ' ')
                .Replace("%20", " ")
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => x.Trim(" \t".ToCharArray())));
        }
    }
}
