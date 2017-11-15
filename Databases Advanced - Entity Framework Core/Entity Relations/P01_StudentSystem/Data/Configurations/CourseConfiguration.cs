namespace P01_StudentSystem.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using P01_StudentSystem.Data.Models;

    public class CourseConfiguration : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.HasKey(e => e.CourseId);

            builder.Property(e => e.Name)
                .HasMaxLength(80)
                .IsUnicode(true)
                .IsRequired(true);

            builder.Property(e => e.Description)
                .IsUnicode(true)
                .IsRequired(false);

            builder.Property(e => e.StartDate)
                .IsRequired(true);

            builder.Property(e => e.EndDate)
                .IsRequired(true);

            builder.Property(e => e.Price)
                .IsRequired(true);
        }
    }
}
