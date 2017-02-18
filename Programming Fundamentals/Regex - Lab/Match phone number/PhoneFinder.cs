namespace Match_phone_number
{
    using System;
    using System.Text.RegularExpressions;

    public class PhoneFinder
    {
        public static void Main(string[] args)
        {
            string phones = Console.ReadLine();
            Regex regex = new Regex(@"\+\d{3}(-|\s)2\1\d{3}\1\d{4}\b");
            var matches = regex.Matches(phones);

            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);
            }
        }
    }
}
