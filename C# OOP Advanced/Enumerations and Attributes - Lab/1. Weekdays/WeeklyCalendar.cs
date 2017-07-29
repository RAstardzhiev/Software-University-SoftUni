namespace _1.Weekdays
{
    using System.Collections.Generic;

    public class WeeklyCalendar
    {
        private IList<WeeklyEntry> entries;

        public WeeklyCalendar()
        {
            this.entries = new List<WeeklyEntry>();
        }

        public IEnumerable<WeeklyEntry> WeeklySchedule => this.entries;

        public void AddEntry(string weekday, string notes)
        {
            this.entries.Add(new WeeklyEntry(weekday, notes));
        }
    }
}
