namespace P03_FootballBetting.Data.Config
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Models;

    public class TownConfig : IEntityTypeConfiguration<Town>
    {
        public void Configure(EntityTypeBuilder<Town> builder)
        {
            builder.HasKey(e => e.TownId);

            builder.HasAlternateKey(e => new { e.Name, e.CountryId });

            builder.Property(e => e.Name)
                .IsRequired(true);

            builder.HasOne(e => e.Country)
                .WithMany(c => c.Towns)
                .HasForeignKey(e => e.CountryId);
        }
    }
}
