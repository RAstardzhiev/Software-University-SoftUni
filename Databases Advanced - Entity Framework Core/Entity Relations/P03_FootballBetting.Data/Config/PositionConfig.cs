namespace P03_FootballBetting.Data.Config
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Models;

    public class PositionConfig : IEntityTypeConfiguration<Position>
    {
        public void Configure(EntityTypeBuilder<Position> builder)
        {
            builder.HasKey(e => e.PositionId);

            builder.HasAlternateKey(e => e.Name);

            builder.Property(e => e.Name)
                .IsUnicode(true)
                .IsRequired(true);
        }
    }
}
