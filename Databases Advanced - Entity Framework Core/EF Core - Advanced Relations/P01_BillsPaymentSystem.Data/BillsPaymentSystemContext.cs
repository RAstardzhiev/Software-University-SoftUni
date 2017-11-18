namespace P01_BillsPaymentSystem.Data
{
    using Microsoft.EntityFrameworkCore;
    using P01_BillsPaymentSystem.Data.Config;
    using P01_BillsPaymentSystem.Data.Config.EntityConfig;
    using P01_BillsPaymentSystem.Data.Models;

    public class BillsPaymentSystemContext : DbContext
    {
        public BillsPaymentSystemContext()
        {
        }

        public BillsPaymentSystemContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }

        public DbSet<CreditCard> CreditCards { get; set; }

        public DbSet<BankAccount> BankAccounts { get; set; }

        public DbSet<PaymentMethod> PaymentMethods { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(DbContextConfig.ConnectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PaymentMethodConfig());
            modelBuilder.ApplyConfiguration(new UserConfig());
            modelBuilder.ApplyConfiguration(new CreditCardConfig());
            modelBuilder.ApplyConfiguration(new BankAccountConfig());
        }
    }
}
