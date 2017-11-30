namespace BusTickets.Data.Config
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using BusTickets.Models;

    public class CustomerConfig : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property(e => e.FirstName)
                .IsRequired(true)
                .IsUnicode(true)
                .HasMaxLength(30);

            builder.Property(e => e.LastName)
                .IsRequired(true)
                .IsUnicode(true)
                .HasMaxLength(30);

            builder.Property(e => e.Gender)
                .HasColumnType("CHAR(1)");

            builder.HasOne(e => e.HomeTown)
                .WithMany(t => t.Customers)
                .HasForeignKey(e => e.HomeTownId);
        }
    }
}
