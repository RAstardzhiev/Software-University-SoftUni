namespace BusTickets.Data.Config
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using BusTickets.Models;

    public class TownConfig : IEntityTypeConfiguration<Town>
    {
        public void Configure(EntityTypeBuilder<Town> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Name)
                .IsRequired(true)
                .IsUnicode(true)
                .HasMaxLength(50);

            builder.HasOne(e => e.Country)
                .WithMany(c => c.Towns)
                .HasForeignKey(e => e.CountryId);
        }
    }
}
