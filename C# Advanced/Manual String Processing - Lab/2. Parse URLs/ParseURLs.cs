namespace _2.Parse_URLs
{
    using System;

    public class ParseURLs
    {
        public static void Main()
        {
            var url = Console.ReadLine().Split(new string[] { "://" }, StringSplitOptions.RemoveEmptyEntries);

            if (url.Length != 2)
            {
                Console.WriteLine("Invalid URL");
                return;
            }

            var protocol = url[0];

            var indexOfServerEnd = url[1].IndexOf('/');

            if (indexOfServerEnd < 0)
            {
                Console.WriteLine("Invalid URL");
                return;
            }

            var server = url[1].Substring(0, indexOfServerEnd);

            var resources = string.Empty;

            if (indexOfServerEnd != url[1].Length - 1)
            {
                resources = url[1].Substring(indexOfServerEnd + 1);
            }

            Console.WriteLine($"Protocol = {protocol}");
            Console.WriteLine($"Server = {server}");
            Console.WriteLine($"Resources = {resources}");
        }
    }
}
