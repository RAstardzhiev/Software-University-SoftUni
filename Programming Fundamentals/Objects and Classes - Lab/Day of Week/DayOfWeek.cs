namespace Day_of_Week
{
    using System;
    using System.Globalization;

    public class DayOfWeek
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();
            DateTime date = DateTime.ParseExact(input, "d-M-yyyy", CultureInfo.InvariantCulture);
            Console.WriteLine(date.DayOfWeek);
        }
    }
}
