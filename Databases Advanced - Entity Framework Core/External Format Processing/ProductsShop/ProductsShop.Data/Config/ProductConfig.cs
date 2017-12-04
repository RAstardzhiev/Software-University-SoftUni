namespace ProductsShop.Data.Config
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using ProductsShop.Models;

    public class ProductConfig : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Name)
                .IsRequired(true)
                .IsUnicode(true)
                .HasMaxLength(125);

            builder.HasOne(e => e.Buyer)
                .WithMany(u => u.BoughtProducts)
                .HasForeignKey(e => e.BuyerId);

            builder.HasOne(e => e.Seller)
                .WithMany(u => u.SoldProducts)
                .HasForeignKey(e => e.SellerId);
        }
    }
}
