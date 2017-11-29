namespace PhotoShare.Data
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using Models;

    internal class AlbumConfig : IEntityTypeConfiguration<Album>
    {
        public void Configure(EntityTypeBuilder<Album> builder)
        {
            builder.HasKey(e => e.Id);

            builder.HasAlternateKey(e => e.Name);

            builder.Property(e => e.Name)
                .IsUnicode()
                .HasMaxLength(50);

            builder.Property(e => e.BackgroundColor)
                .IsRequired(false);

            builder.Property(e => e.IsPublic)
                .IsRequired()
                .HasDefaultValue(false);
        }
    }
}
