namespace MentorGroup
{
    using System;
    using System.Collections.Generic;

    public class Student
    {
        public List<string> Comment = new List<string>();
        public List<DateTime> AttendedDates = new List<DateTime>();

        public string Name { get; set; }
    }
}
