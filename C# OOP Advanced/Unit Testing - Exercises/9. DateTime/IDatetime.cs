namespace _9.DateTime
{
    using System;

    public interface IDatetime
    {
        DateTime Now();

        void AddDays(DateTime date, double daysToAdd);

        TimeSpan SubstractDays(DateTime date, int daysToSybstract);
    }
}
