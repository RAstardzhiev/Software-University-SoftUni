namespace _3.Sales_Database
{
    using System.Data.Entity;
    using Models;
    using Migrations;

    public class SalesContext : DbContext
    {
        public SalesContext()
            : base("name=SalesContext")
        {
            //Database.SetInitializer(new InitializeAndSeed());
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<SalesContext, Configuration>());
        }

        public virtual DbSet<Product> Products { get; set; }

        public virtual DbSet<Customer> Customers { get; set; }

        public virtual DbSet<StoreLocation> StoreLocations { get; set; }

        public virtual DbSet<Sale> Sales { get; set; }
    }
}