namespace TeamBuilder.Data.Config
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using TeamBuilder.Models;

    public class UserTeamConfig : IEntityTypeConfiguration<UserTeam>
    {
        public void Configure(EntityTypeBuilder<UserTeam> builder)
        {
            builder.HasKey(e => new { e.UserId, e.TeamId });

            builder.HasOne(e => e.User)
                .WithMany(u => u.UserTeams)
                .HasForeignKey(e => e.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(e => e.Team)
                .WithMany(t => t.TeamUsers)
                .HasForeignKey(e => e.TeamId);
        }
    }
}
