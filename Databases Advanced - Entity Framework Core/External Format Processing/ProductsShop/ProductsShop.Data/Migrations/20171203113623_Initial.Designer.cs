namespace ProductsShop.Data.Migrations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Infrastructure;
    using Microsoft.EntityFrameworkCore.Metadata;
    using Microsoft.EntityFrameworkCore.Migrations;

    [DbContext(typeof(ProductsShopContext))]
    [Migration("20171203113623_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ProductsShop.Models.CategoriesProducts", b =>
                {
                    b.Property<int>("CategoryId");

                    b.Property<int>("ProductId");

                    b.HasKey("CategoryId", "ProductId");

                    b.HasIndex("ProductId");

                    b.ToTable("CategoriesProducts");
                });

            modelBuilder.Entity("ProductsShop.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(15)
                        .IsUnicode(true);

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("ProductsShop.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("BuyerId");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(125)
                        .IsUnicode(true);

                    b.Property<decimal>("Price");

                    b.Property<int>("SellerId");

                    b.HasKey("Id");

                    b.HasIndex("BuyerId");

                    b.HasIndex("SellerId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("ProductsShop.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("Age");

                    b.Property<string>("FirstName")
                        .HasMaxLength(30)
                        .IsUnicode(true);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .IsUnicode(true);

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("ProductsShop.Models.CategoriesProducts", b =>
                {
                    b.HasOne("ProductsShop.Models.Category", "Category")
                        .WithMany("ProductsCategories")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ProductsShop.Models.Product", "Product")
                        .WithMany("CategoriesProducts")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ProductsShop.Models.Product", b =>
                {
                    b.HasOne("ProductsShop.Models.User", "Buyer")
                        .WithMany("BoughtProducts")
                        .HasForeignKey("BuyerId");

                    b.HasOne("ProductsShop.Models.User", "Seller")
                        .WithMany("SoldProducts")
                        .HasForeignKey("SellerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
