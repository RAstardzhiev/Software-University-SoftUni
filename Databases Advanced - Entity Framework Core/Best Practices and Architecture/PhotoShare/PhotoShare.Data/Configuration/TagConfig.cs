namespace PhotoShare.Data.Configuration
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using Models;

    internal class TagConfig : IEntityTypeConfiguration<Tag>
    {
        public void Configure(EntityTypeBuilder<Tag> builder)
        {
            builder.HasKey(e => e.Id);

            builder.HasAlternateKey(e => e.Name);

            builder.Property(e => e.Name)
                .HasMaxLength(50);
        }
    }
}
