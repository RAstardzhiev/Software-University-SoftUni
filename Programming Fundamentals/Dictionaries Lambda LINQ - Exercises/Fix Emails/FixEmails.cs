namespace Fix_Emails
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class FixEmails
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> emails = new Dictionary<string, string>();

            while (true)
            {
                string name = Console.ReadLine();

                if (name.Equals("stop"))
                {
                    break;
                }

                emails[name] = Console.ReadLine();
            }

            foreach (KeyValuePair<string, string> item in emails.ToList())
            {
                if (item.Value.ToLower().EndsWith("us") || item.Value.ToLower().EndsWith("uk"))
                {
                    emails.Remove(item.Key);
                }
            }

            foreach (KeyValuePair<string, string> item in emails)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
