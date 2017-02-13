namespace Average_Grades
{
    using System.Collections.Generic;
    using System.Linq;

    public class Student
    {
        public List<float> Grades { get; set; }

        public string Name { get; set; }

        public float AvarageGrade => this.Grades.Average();
    }
}
