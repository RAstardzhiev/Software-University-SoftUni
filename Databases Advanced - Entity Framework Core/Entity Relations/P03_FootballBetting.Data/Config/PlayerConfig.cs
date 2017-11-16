namespace P03_FootballBetting.Data.Config
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Models;

    public class PlayerConfig : IEntityTypeConfiguration<Player>
    {
        public void Configure(EntityTypeBuilder<Player> builder)
        {
            builder.HasKey(e => e.PlayerId);

            builder.Property(e => e.Name)
                .IsRequired(true);

            builder.Property(e => e.IsInjured)
                .IsRequired(true)
                .HasDefaultValue(false);

            builder.HasOne(e => e.Team)
                .WithMany(t => t.Players)
                .HasForeignKey(e => e.TeamId);

            builder.HasOne(e => e.Position)
                .WithMany(p => p.Players)
                .HasForeignKey(e => e.PositionId);
        }
    }
}
