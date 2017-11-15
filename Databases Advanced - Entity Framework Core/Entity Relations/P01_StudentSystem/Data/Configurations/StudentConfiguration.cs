namespace P01_StudentSystem.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using P01_StudentSystem.Data.Models;

    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasKey(e => e.StudentId);

            builder.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(true)
                .IsRequired(true);

            builder.Property(e => e.PhoneNumber) 
                .HasColumnType("CHAR(10)")
                .IsUnicode(false)
                .IsRequired(false);

            builder.Property(e => e.RegisteredOn)
                .IsRequired(true)
                .HasDefaultValueSql("GETDATE()");

            builder.Property(e => e.Birthday)
                .IsRequired(false);
        }
    }
}
