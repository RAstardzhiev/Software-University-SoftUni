namespace Student_Groups
{
    using System.Collections.Generic;

    public class Group
    {
        public List<Student> Students = new List<Student>();

        public Town Town { get; set; }
    }
}
