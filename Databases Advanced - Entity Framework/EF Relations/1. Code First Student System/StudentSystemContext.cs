namespace _1.Code_First_Student_System
{
    using System.Data.Entity;
    using Models;

    public class StudentSystemContext : DbContext
    {
        public StudentSystemContext()
            : base("name=StudentSystemContext")
        {
        }

        public virtual DbSet<Student> Student { get; set; }

        public virtual DbSet<Course> Courses { get; set; }

        public virtual DbSet<Resource> Resources { get; set; }

        public virtual DbSet<Homework> Homeworks { get; set; }
    }
}