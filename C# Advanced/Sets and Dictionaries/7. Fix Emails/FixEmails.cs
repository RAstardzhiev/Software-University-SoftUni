namespace _7.Fix_Emails
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class FixEmails
    {
        public static void Main()
        {
            var emails = new Dictionary<string, string>();

            while (true)
            {
                var name = Console.ReadLine();
                if (name.ToLower() == "stop")
                {
                    break;
                }

                var email = Console.ReadLine();
                if (email.EndsWith("us") || email.EndsWith("uk"))
                {
                    continue;
                }

                emails[name] = email;
            }

            Console.WriteLine(string.Join(Environment.NewLine, emails.Select(kvp => $"{kvp.Key} -> {kvp.Value}")));
        }
    }
}
