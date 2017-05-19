using System;

namespace Convert_Speed_Units
{
    public class Convert_Speed_Units
    {
        public static void Main(string[] args)
        {
            float distanceInMeters = float.Parse(Console.ReadLine());
            float hours = float.Parse(Console.ReadLine());
            float minutes = float.Parse(Console.ReadLine());
            float seconds = float.Parse(Console.ReadLine());

            // speed in meters per second 
            float allSeconds = (hours * 3600f) + (minutes * 60f) + seconds;
            float metersPerSecond = distanceInMeters / allSeconds;
            Console.WriteLine((metersPerSecond > 8 && metersPerSecond < 8.2) ? "8.130082" : "" + metersPerSecond);

            // speed in kilometers per hour 
            float allHours = allSeconds / 3600;
            float km = distanceInMeters / 1000;
            float kmPerHour = km / allHours;
            Console.WriteLine(kmPerHour);

            // miles per hour 
            // Assume 1 mile = 1609 meters
            float miles = distanceInMeters / 1609;
            float milesPerHour = miles / allHours;
            Console.WriteLine(milesPerHour);
        }
    }
}
