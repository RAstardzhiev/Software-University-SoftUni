namespace P03_FootballBetting.Data.Config
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Models;

    public class ColorConfig : IEntityTypeConfiguration<Color>
    {
        public void Configure(EntityTypeBuilder<Color> builder)
        {
            builder.HasKey(e => e.ColorId);

            builder.HasAlternateKey(e => e.Name);

            builder.Property(e => e.Name)
                .IsUnicode(true)
                .IsRequired(true);
        }
    }
}
