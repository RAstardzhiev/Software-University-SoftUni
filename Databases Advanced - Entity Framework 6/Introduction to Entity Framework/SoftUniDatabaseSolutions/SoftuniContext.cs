namespace Introduction_to_Entity_Framework
{
    using System.Data.Entity;
    using Introduction_to_Entity_Framework.Models;

    public partial class SoftuniContext : DbContext
    {
        public SoftuniContext()
            : base("name=SoftuniContext")
        {
        }

        public virtual DbSet<Address> Addresses { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Project> Projects { get; set; }
        public virtual DbSet<Town> Towns { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Address>()
                .Property(e => e.AddressText)
                .IsUnicode(false);

            modelBuilder.Entity<Department>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Department>()
                .HasMany(e => e.Employees)
                .WithRequired(e => e.Department)
                .HasForeignKey(e => e.DepartmentID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.MiddleName)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.JobTitle)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.Salary)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.Departments)
                .WithRequired(e => e.Manager)
                .HasForeignKey(e => e.ManagerID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.Employees)
                .WithOptional(e => e.Manager)
                .HasForeignKey(e => e.ManagerID);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.Projects)
                .WithMany(e => e.Employees)
                .Map(m => m.ToTable("EmployeesProjects").MapLeftKey("EmployeeID").MapRightKey("ProjectID"));

            modelBuilder.Entity<Project>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Town>()
                .Property(e => e.Name)
                .IsUnicode(false);
        }
    }
}
