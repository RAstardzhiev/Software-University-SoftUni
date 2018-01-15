namespace GringottsDatabaseSolutions
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using GringottsDatabaseSolutions.Models;

    public partial class GringiottsContext : DbContext
    {
        public GringiottsContext()
            : base("name=GringiottsContext")
        {
        }

        public virtual DbSet<WizzardDeposit> WizzardDeposits { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<WizzardDeposit>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<WizzardDeposit>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<WizzardDeposit>()
                .Property(e => e.Notes)
                .IsUnicode(false);

            modelBuilder.Entity<WizzardDeposit>()
                .Property(e => e.MagicWandCreator)
                .IsUnicode(false);

            modelBuilder.Entity<WizzardDeposit>()
                .Property(e => e.DepositGroup)
                .IsUnicode(false);

            modelBuilder.Entity<WizzardDeposit>()
                .Property(e => e.DepositAmount)
                .HasPrecision(8, 2);

            modelBuilder.Entity<WizzardDeposit>()
                .Property(e => e.DepositInterest)
                .HasPrecision(5, 2);

            modelBuilder.Entity<WizzardDeposit>()
                .Property(e => e.DepositCharge)
                .HasPrecision(8, 2);
        }
    }
}
