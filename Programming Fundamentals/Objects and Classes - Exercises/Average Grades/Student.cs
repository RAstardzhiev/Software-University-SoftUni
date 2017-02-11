namespace Average_Grades
{
    using System.Collections.Generic;
    using System.Linq;

    public class Student
    {
        public string Name { get; set; }

        public List<double> Grades { get; set; }

        public double AvarageGrade
        {
            get { return this.Grades.Sum() / this.Grades.Count; }
        }
    }
}
