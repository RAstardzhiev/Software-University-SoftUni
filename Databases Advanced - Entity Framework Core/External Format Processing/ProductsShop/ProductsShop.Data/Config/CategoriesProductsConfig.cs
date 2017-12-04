namespace ProductsShop.Data.Config
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using ProductsShop.Models;

    public class CategoriesProductsConfig : IEntityTypeConfiguration<CategoriesProducts>
    {
        public void Configure(EntityTypeBuilder<CategoriesProducts> builder)
        {
            builder.HasKey(e => new { e.CategoryId, e.ProductId });

            builder.HasOne(e => e.Category)
                .WithMany(c => c.ProductsCategories)
                .HasForeignKey(e => e.CategoryId);

            builder.HasOne(e => e.Product)
                .WithMany(p => p.CategoriesProducts)
                .HasForeignKey(e => e.ProductId);
        }
    }
}
