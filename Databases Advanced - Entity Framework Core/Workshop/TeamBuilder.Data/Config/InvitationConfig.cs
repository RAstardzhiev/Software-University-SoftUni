namespace TeamBuilder.Data.Config
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using TeamBuilder.Models;

    public class InvitationConfig : IEntityTypeConfiguration<Invitation>
    {
        public void Configure(EntityTypeBuilder<Invitation> builder)
        {
            builder.HasKey(e => e.Id);

            builder.HasOne(e => e.InvitedUser)
                .WithMany(u => u.Invitations)
                .HasForeignKey(e => e.InvitedUserId);

            builder.HasOne(e => e.Team)
                .WithMany(t => t.Invitations)
                .HasForeignKey(e => e.TeamId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
