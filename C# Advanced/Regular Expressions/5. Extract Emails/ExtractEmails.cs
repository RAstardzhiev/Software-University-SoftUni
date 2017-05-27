namespace _5.Extract_Emails
{
    using System;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class ExtractEmails
    {
        public static void Main() // How to solve without TrimEnd...
        {
            var pattern = @"^[a-zA-Z0-9][\w-.]+@[a-zA-Z][a-zA-Z-]*(\.[a-zA-Z]+[a-zA-Z-]*?)+$";
            var regex = new Regex(pattern);

            var input = Console.ReadLine().Split().Select(x => x.TrimEnd(".,;:!?".ToCharArray()));

            foreach (var item in input)
            {
                if (Regex.IsMatch(item, pattern))
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
