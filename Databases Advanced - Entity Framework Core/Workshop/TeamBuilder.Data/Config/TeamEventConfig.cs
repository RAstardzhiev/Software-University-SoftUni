namespace TeamBuilder.Data.Config
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using TeamBuilder.Models;

    public class TeamEventConfig : IEntityTypeConfiguration<TeamEvent>
    {
        public void Configure(EntityTypeBuilder<TeamEvent> builder)
        {
            builder.HasKey(e => new { e.TeamId, e.EventId });

            builder.HasOne(e => e.Team)
                .WithMany(t => t.TeamEvents)
                .HasForeignKey(e => e.TeamId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(e => e.Event)
                .WithMany(e => e.EventTeams)
                .HasForeignKey(e => e.EventId);
        }
    }
}
