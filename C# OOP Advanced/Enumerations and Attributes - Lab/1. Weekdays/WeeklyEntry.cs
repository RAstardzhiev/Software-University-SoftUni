namespace _1.Weekdays
{
    using System;

    public class WeeklyEntry : IComparable<WeeklyEntry>
    {
        private WeekDay day;
        private string note;

        public WeeklyEntry(string day, string note)
        {
            this.Day = (WeekDay)Enum.Parse(typeof(WeekDay), day);
            this.note = note;
        }

        public WeekDay Day
        {
            get
            {
                return this.day;
            }

            private set
            {
                this.day = value;
            }
        }

        public int CompareTo(WeeklyEntry other)
        {
            var comparison = this.day.CompareTo(other.day);

            return comparison == 0
                ? this.note.CompareTo(other.note)
                : comparison;
        }

        public override string ToString()
        {
            return $"{this.day.ToString()} - {this.note}";
        }
    }
}
