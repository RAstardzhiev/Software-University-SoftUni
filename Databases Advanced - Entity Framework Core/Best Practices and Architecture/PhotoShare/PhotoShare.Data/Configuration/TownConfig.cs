namespace PhotoShare.Data.Configuration
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using Models;

    class TownConfig : IEntityTypeConfiguration<Town>
    {
        public void Configure(EntityTypeBuilder<Town> builder)
        {
            builder.HasKey(e => e.Id);

            builder.HasIndex(e => new { e.Name, e.Country })
                .IsUnique(true);

            builder.Property(e => e.Name)
                .IsRequired(true)
                .HasMaxLength(60);

            builder.Property(e => e.Country)
                .HasMaxLength(60);
        }
    }
}
