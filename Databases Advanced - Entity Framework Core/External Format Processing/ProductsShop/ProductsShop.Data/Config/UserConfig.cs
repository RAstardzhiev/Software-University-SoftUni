namespace ProductsShop.Data.Config
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using ProductsShop.Models;

    public class UserConfig : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property(e => e.FirstName)
                .IsRequired(false)
                .IsUnicode(true)
                .HasMaxLength(30);

            builder.Property(e => e.LastName)
                .IsRequired(true)
                .IsUnicode(true)
                .HasMaxLength(30);
        }
    }
}
