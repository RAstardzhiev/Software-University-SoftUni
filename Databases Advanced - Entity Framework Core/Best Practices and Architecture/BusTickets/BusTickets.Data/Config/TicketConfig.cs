namespace BusTickets.Data.Config
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using BusTickets.Models;

    public class TicketConfig : IEntityTypeConfiguration<Ticket>
    {
        public void Configure(EntityTypeBuilder<Ticket> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Seat)
                .IsRequired(true)
                .IsUnicode(false)
                .HasMaxLength(5);

            builder.HasOne(e => e.Customer)
                .WithMany(c => c.Tickets)
                .HasForeignKey(e => e.CustomerId);

            builder.HasOne(e => e.Trip)
                .WithMany(t => t.Tickets)
                .HasForeignKey(e => e.TripId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
