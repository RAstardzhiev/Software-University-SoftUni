namespace P03_FootballBetting.Data.Config
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Models;

    public class CountryConfig : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder.HasKey(e => e.CountryId);

            builder.HasAlternateKey(e => e.Name);

            builder.Property(e => e.Name)
                .IsUnicode(true)
                .IsRequired(true);
        }
    }
}
