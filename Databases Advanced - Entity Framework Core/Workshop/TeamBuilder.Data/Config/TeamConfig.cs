namespace TeamBuilder.Data.Config
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using TeamBuilder.Models;
    using TeamBuilder.Models.Helpers;

    public class TeamConfig : IEntityTypeConfiguration<Team>
    {
        public void Configure(EntityTypeBuilder<Team> builder)
        {
            builder.HasKey(e => e.Id);

            builder.HasAlternateKey(e => e.Name);

            builder.Property(e => e.Name)
                .HasMaxLength(Constants.TeamNameMaxLength)
                .IsRequired(true);

            builder.Property(e => e.Description)
                .HasMaxLength(Constants.TeamDescriptionMaxLength);

            builder.Property(e => e.Acronym)
                .HasMaxLength(Constants.TeamAcronymExactLength)
                .IsRequired(true);

            builder.HasOne(e => e.Creator)
                .WithMany(u => u.CreatedTeams)
                .HasForeignKey(e => e.CreatorId);
        }
    }
}
