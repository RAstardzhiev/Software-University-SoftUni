namespace Fix_Emails
{
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class FixEmails
    {
        public static void Main(string[] args)
        {
            string[] data = File.ReadAllLines("../../InputOutput/Input.txt");
            Dictionary<string, string> allowedEmails = new Dictionary<string, string>();

            for (int i = 1; i < data.Length; i += 2)
            {
                if (data[i].EndsWith("uk") || data[i].EndsWith("us"))
                {
                    continue;
                }

                allowedEmails[data[i - 1]] = data[i];
            }

            string[] result = allowedEmails
                .Select(x => $"{x.Key} -> {x.Value}")
                .ToArray();

            File.WriteAllLines("../../InputOutput/Output.txt", result);
        }
    }
}
