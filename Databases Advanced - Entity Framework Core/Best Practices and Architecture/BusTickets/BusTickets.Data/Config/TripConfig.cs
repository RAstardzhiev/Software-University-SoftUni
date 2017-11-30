namespace BusTickets.Data.Config
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using BusTickets.Models;
    using BusTickets.Models.Enumerations;

    public class TripConfig : IEntityTypeConfiguration<Trip>
    {
        public void Configure(EntityTypeBuilder<Trip> builder)
        {
            builder.HasKey(e => e.Id);

            builder.HasOne(e => e.OriginBusStation)
                .WithMany(bs => bs.StartingTrips)
                .HasForeignKey(e => e.OriginBusStationId);

            builder.HasOne(e => e.DestinationBusStation)
                .WithMany(bs => bs.ArrivingTrips)
                .HasForeignKey(e => e.DestinationBusStationId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(e => e.BusCompany)
                .WithMany(bc => bc.Trips)
                .HasForeignKey(e => e.BusCompanyId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
