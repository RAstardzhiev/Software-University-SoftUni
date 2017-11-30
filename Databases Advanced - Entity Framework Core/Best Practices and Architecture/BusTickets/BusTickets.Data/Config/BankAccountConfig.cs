namespace BusTickets.Data.Config
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using BusTickets.Models;

    public class BankAccountConfig : IEntityTypeConfiguration<BankAccount>
    {
        public void Configure(EntityTypeBuilder<BankAccount> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property(e => e.AccountNumber)
                .IsRequired(true)
                .IsUnicode(false)
                .HasMaxLength(30);

            builder.HasOne(e => e.Customer)
                .WithMany(c => c.BankAccounts)
                .HasForeignKey(e => e.CustomerId);
        }
    }
}
