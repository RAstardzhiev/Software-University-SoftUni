namespace Student_Groups
{
    using System.Collections.Generic;

    public class Town
    {
        public List<Student> Students = new List<Student>();

        public string Name { get; set; }

        public int SeatsAvalable { get; set; }
    }
}
