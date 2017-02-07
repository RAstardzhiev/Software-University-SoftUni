namespace Count_Work_Days
{
    using System;
    using System.Globalization;

    public class CountWorkDays
    {
        public static void Main(string[] args)
        {
            DateTime startDay = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
            DateTime endDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
            Console.WriteLine(GetWorkingDays(startDay, endDate));
        }

        private static int GetWorkingDays(DateTime startDay, DateTime endDate)
        {
            int workingDays = 0;
            for (DateTime i = startDay; i <= endDate; i = i.AddDays(1))
            {
                if (IsWorkingDay(i))
                {
                    workingDays++;
                }
            }

            return workingDays;
        }

        private static Boolean IsWorkingDay(DateTime dayToCheck)
        {
            if (dayToCheck.DayOfWeek == DayOfWeek.Saturday || dayToCheck.DayOfWeek == DayOfWeek.Sunday)
            {
                return false;
            }

            DateTime[] holidays = new DateTime[]
                                                {
                                                    new DateTime(0001, 01, 01),
                                                    new DateTime(0001, 03, 03),
                                                    new DateTime(0001, 05, 01),
                                                    new DateTime(0001, 05, 06),
                                                    new DateTime(0001, 05, 24),
                                                    new DateTime(0001, 09, 06),
                                                    new DateTime(0001, 09, 22),
                                                    new DateTime(0001, 11, 01),
                                                    new DateTime(0001, 12, 24),
                                                    new DateTime(0001, 12, 25),
                                                    new DateTime(0001, 12, 26)
                                                };

            for (int i = 0; i < holidays.Length; i++)
            {
                if (dayToCheck.Day.Equals(holidays[i].Day) && dayToCheck.Month.Equals(holidays[i].Month))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
