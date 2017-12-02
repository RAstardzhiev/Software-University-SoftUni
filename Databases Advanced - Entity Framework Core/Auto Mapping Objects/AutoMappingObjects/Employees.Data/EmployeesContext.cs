namespace Employees.Data
{
    using Employees.Data.Config;
    using Employees.Models;
    using Microsoft.EntityFrameworkCore;

    public class EmployeesContext : DbContext
    {
        public EmployeesContext()
        {
        }

        public EmployeesContext( DbContextOptions options) 
            : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(DbConfig.ConnectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new EmployeeConfig());
        }
    }
}
