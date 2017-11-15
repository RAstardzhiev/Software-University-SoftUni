namespace P01_StudentSystem.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using P01_StudentSystem.Data.Models;

    public class ResourceConfiguration : IEntityTypeConfiguration<Resource>
    {
        public void Configure(EntityTypeBuilder<Resource> builder)
        {
            builder.HasKey(e => e.ResourceId);

            builder.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(true)
                .IsRequired(true);

            builder.Property(e => e.Url)
                .IsUnicode(false)
                .IsRequired(true);

            builder.Property(e => e.ResourceType)
                .IsRequired(true);

            builder.Property(e => e.CourseId)
                .IsRequired(true);

            builder.HasOne(e => e.Course)
                .WithMany(c => c.Resources)
                .HasForeignKey(e => e.CourseId);
        }
    }
}
