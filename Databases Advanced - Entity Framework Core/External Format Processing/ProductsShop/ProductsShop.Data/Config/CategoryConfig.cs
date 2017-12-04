namespace ProductsShop.Data.Config
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using ProductsShop.Models;

    public class CategoryConfig : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Name)
                .IsRequired(true)
                .IsUnicode(true)
                .HasMaxLength(15);
        }
    }
}
