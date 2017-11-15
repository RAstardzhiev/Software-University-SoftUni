namespace P01_StudentSystem.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using P01_StudentSystem.Data.Models;

    public class HomeworkConfiguration : IEntityTypeConfiguration<Homework>
    {
        public void Configure(EntityTypeBuilder<Homework> builder)
        {
            builder.HasKey(e => e.HomeworkId);

            builder.Property(e => e.Content) 
                .IsUnicode(false)
                .IsRequired(true);

            builder.Property(e => e.ContentType)
                .IsRequired(true);

            builder.Property(e => e.SubmissionTime)
                .IsRequired(true);

            builder.Property(e => e.StudentId)
                .IsRequired(true);

            builder.HasOne(e => e.Student)
                .WithMany(s => s.HomeworkSubmissions)
                .HasForeignKey(e => e.StudentId);

            builder.Property(e => e.CourseId)
                .IsRequired(true);

            builder.HasOne(e => e.Course)
                .WithMany(c => c.HomeworkSubmissions)
                .HasForeignKey(e => e.CourseId);
        }
    }
}
