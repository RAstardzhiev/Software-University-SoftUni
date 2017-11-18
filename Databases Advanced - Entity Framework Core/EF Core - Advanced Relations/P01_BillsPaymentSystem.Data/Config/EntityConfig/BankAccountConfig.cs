namespace P01_BillsPaymentSystem.Data.Config.EntityConfig
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Models;

    public class BankAccountConfig : IEntityTypeConfiguration<BankAccount>
    {
        public void Configure(EntityTypeBuilder<BankAccount> builder)
        {
            builder.HasKey(e => e.BankAccountId);

            builder.Property(e => e.BankName)
                .HasMaxLength(50)
                .IsRequired(true);

            builder.Property(e => e.SWIFT)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsRequired(true);
        }
    }
}
