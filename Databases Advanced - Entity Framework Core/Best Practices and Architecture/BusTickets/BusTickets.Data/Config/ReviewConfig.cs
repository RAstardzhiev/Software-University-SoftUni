namespace BusTickets.Data.Config
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using BusTickets.Models;

    public class ReviewConfig : IEntityTypeConfiguration<Review>
    {
        public void Configure(EntityTypeBuilder<Review> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Content)
                .IsRequired(true)
                .IsUnicode(true)
                .HasMaxLength(255);

            builder.Property(e => e.PublishDate)
                .HasDefaultValueSql("GETDATE()");
            
            builder.HasOne(e => e.BusCompany)
                .WithMany(bs => bs.Reviews)
                .HasForeignKey(e => e.BusCompanyId);

            builder.HasOne(e => e.Customer)
                .WithMany(c => c.Reviews)
                .HasForeignKey(e => e.CustomerId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
