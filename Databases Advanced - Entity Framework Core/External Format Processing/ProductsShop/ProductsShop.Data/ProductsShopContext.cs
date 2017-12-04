namespace ProductsShop.Data
{
    using Microsoft.EntityFrameworkCore;
    using ProductsShop.Data.Config;
    using ProductsShop.Models;

    public class ProductsShopContext : DbContext
    {
        public ProductsShopContext()
        {
        }

        public ProductsShopContext(DbContextOptions options) 
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<CategoriesProducts> CategoriesProducts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(DbConfig.ConnectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new UserConfig());
            modelBuilder.ApplyConfiguration(new ProductConfig());
            modelBuilder.ApplyConfiguration(new CategoryConfig());
            modelBuilder.ApplyConfiguration(new CategoriesProductsConfig());
        }
    }
}
