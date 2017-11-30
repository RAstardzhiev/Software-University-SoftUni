namespace BusTickets.Data.Config
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using BusTickets.Models;

    public class BusCompanyConfig : IEntityTypeConfiguration<BusCompany>
    {
        public void Configure(EntityTypeBuilder<BusCompany> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Name)
                .HasMaxLength(100)
                .IsRequired(true)
                .IsUnicode(true);

            builder.HasOne(e => e.Country)
                .WithMany(c => c.BusCompanies)
                .HasForeignKey(e => e.CountryId);
        }
    }
}
