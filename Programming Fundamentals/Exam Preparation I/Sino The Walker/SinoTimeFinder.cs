namespace Sino_The_Walker
{
    using System;
    using System.Globalization;
    using System.Text.RegularExpressions;

    public class SinoTimeFinder
    {
        public static void Main(string[] args)
        {
            DateTime start = DateTime.ParseExact(Regex.Replace(Console.ReadLine(), @"[^0-9:]+", string.Empty), "H:m:s", CultureInfo.InvariantCulture);

            int steps = int.Parse(Regex.Replace(Console.ReadLine(), @"[^0-9]+", string.Empty)) % 86400;
            int timePerStep = int.Parse(Regex.Replace(Console.ReadLine(), @"[^0-9]+", string.Empty)) % 86400;

            int totalSeconds = steps * timePerStep;

            DateTime arrival = start.AddSeconds(totalSeconds);

            Console.WriteLine($"Time Arrival: {arrival.Hour:00}:{arrival.Minute:00}:{arrival.Second:00}");
        }
    }
}
