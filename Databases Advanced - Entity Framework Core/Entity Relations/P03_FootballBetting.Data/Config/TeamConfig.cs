namespace P03_FootballBetting.Data.Config
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Models;

    public class TeamConfig : IEntityTypeConfiguration<Team>
    {
        public void Configure(EntityTypeBuilder<Team> builder)
        {
            builder.HasKey(e => e.TeamId);

            builder.Property(e => e.Name)
                .IsRequired(true);

            builder.Property(e => e.LogoUrl)
                .IsUnicode(false)
                .IsRequired(true);

            builder.Property(e => e.Initials)
                .HasColumnType("NCHAR(3)")
                .IsRequired(true);

            builder.HasOne(e => e.PrimaryKitColor)
                .WithMany(c => c.PrimaryKitTeams)
                .HasForeignKey(e => e.PrimaryKitColorId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(e => e.SecondaryKitColor)
                .WithMany(c => c.SecondaryKitTeams)
                .HasForeignKey(e => e.SecondaryKitColorId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(e => e.Town)
                .WithMany(t => t.Teams)
                .HasForeignKey(e => e.TownId);
        }
    }
}
