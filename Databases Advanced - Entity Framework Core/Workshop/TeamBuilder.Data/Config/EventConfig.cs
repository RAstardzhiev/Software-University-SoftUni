namespace TeamBuilder.Data.Config
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using TeamBuilder.Models;
    using TeamBuilder.Models.Helpers;

    public class EventConfig : IEntityTypeConfiguration<Event>
    {
        public void Configure(EntityTypeBuilder<Event> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Name)
                .HasMaxLength(Constants.EventNameMaxLength)
                .IsRequired(true);

            builder.Property(e => e.Description)
                .HasMaxLength(Constants.EventDescriptionMaxLength);

            builder.HasOne(e => e.Creator)
                .WithMany(u => u.Events)
                .HasForeignKey(e => e.CreatorId);
        }
    }
}
