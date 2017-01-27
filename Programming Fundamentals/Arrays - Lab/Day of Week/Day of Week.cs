namespace Day_of_Week
{
    using System;

    public class Day_of_Week
    {
        public static void Main(string[] args)
        {
            int day = int.Parse(Console.ReadLine()) - 1;
            string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            Console.WriteLine((day >= 0 && day <= 6) ? days[day] : "Invalid Day!");
        }
    }
}
