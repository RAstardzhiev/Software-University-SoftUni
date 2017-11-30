namespace BusTickets.Data
{
    using BusTickets.Data.Config;
    using BusTickets.Models;
    using Microsoft.EntityFrameworkCore;

    public class BusTicketsContext : DbContext
    {
        public BusTicketsContext()
        {
        }

        public BusTicketsContext(DbContextOptions options) 
            :base(options)
        {
        }

        public DbSet<BusCompany> BusCompanies { get; set; }

        public DbSet<Country> Countries { get; set; }

        public DbSet<Ticket> Tickets { get; set; }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Trip> Trips { get; set; }

        public DbSet<Town> Towns { get; set; }

        public DbSet<BusStation> BusStations { get; set; }

        public DbSet<Review> Reviews { get; set; }

        public DbSet<BankAccount> BankAccounts { get; set; }

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

            modelBuilder.ApplyConfiguration(new BusCompanyConfig());
            modelBuilder.ApplyConfiguration(new CountryConfig());
            modelBuilder.ApplyConfiguration(new TicketConfig());
            modelBuilder.ApplyConfiguration(new CustomerConfig());
            modelBuilder.ApplyConfiguration(new TripConfig());
            modelBuilder.ApplyConfiguration(new TownConfig());
            modelBuilder.ApplyConfiguration(new BusStationConfig());
            modelBuilder.ApplyConfiguration(new ReviewConfig());
            modelBuilder.ApplyConfiguration(new BankAccountConfig());
        }
    }
}
