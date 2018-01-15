namespace _1.Code_First_Student_System
{
    using System.Data.Entity;
    using Models;
    using Migrations;
    using Photos;

    public class StudentSystemContext : DbContext
    {
        public StudentSystemContext()
            : base("name=StudentSystemContext")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<StudentSystemContext, Configuration>());
        }

        public virtual DbSet<Student> Student { get; set; }

        public virtual DbSet<Course> Courses { get; set; }

        public virtual DbSet<Resource> Resources { get; set; }

        public virtual DbSet<Homework> Homeworks { get; set; }

        public virtual DbSet<License> Licenses { get; set; }

        public virtual DbSet<Photographer> Photographers { get; set; }

        public virtual DbSet<Picture> Pictures { get; set; }

        public virtual DbSet<Album> Albums { get; set; }

        public virtual DbSet<Tag> Tags { get; set; }
    }
}