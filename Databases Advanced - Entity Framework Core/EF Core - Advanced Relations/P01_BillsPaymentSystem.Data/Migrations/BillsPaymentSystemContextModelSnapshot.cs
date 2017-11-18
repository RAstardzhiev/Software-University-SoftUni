namespace P01_BillsPaymentSystem.Data.Migrations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Infrastructure;
    using Microsoft.EntityFrameworkCore.Metadata;
    using System;

    [DbContext(typeof(BillsPaymentSystemContext))]
    partial class BillsPaymentSystemContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("P01_BillsPaymentSystem.Data.Models.BankAccount", b =>
                {
                    b.Property<int>("BankAccountId")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("Balance");

                    b.Property<string>("BankName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("SWIFT")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.HasKey("BankAccountId");

                    b.ToTable("BankAccounts");
                });

            modelBuilder.Entity("P01_BillsPaymentSystem.Data.Models.CreditCard", b =>
                {
                    b.Property<int>("CreditCardId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("ExpirationDate");

                    b.Property<decimal>("Limit");

                    b.Property<decimal>("MoneyOwed");

                    b.HasKey("CreditCardId");

                    b.ToTable("CreditCards");
                });

            modelBuilder.Entity("P01_BillsPaymentSystem.Data.Models.PaymentMethod", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("BankAccountId");

                    b.Property<int?>("CreditCardId");

                    b.Property<int>("Type");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("BankAccountId")
                        .IsUnique()
                        .HasFilter("[BankAccountId] IS NOT NULL");

                    b.HasIndex("CreditCardId")
                        .IsUnique()
                        .HasFilter("[CreditCardId] IS NOT NULL");

                    b.HasIndex("UserId", "BankAccountId", "CreditCardId")
                        .IsUnique()
                        .HasFilter("[BankAccountId] IS NOT NULL AND [CreditCardId] IS NOT NULL");

                    b.ToTable("PaymentMethods");
                });

            modelBuilder.Entity("P01_BillsPaymentSystem.Data.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(80)
                        .IsUnicode(false);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(true);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(true);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(25)
                        .IsUnicode(false);

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("P01_BillsPaymentSystem.Data.Models.PaymentMethod", b =>
                {
                    b.HasOne("P01_BillsPaymentSystem.Data.Models.BankAccount", "BankAccount")
                        .WithOne("PaymentMethod")
                        .HasForeignKey("P01_BillsPaymentSystem.Data.Models.PaymentMethod", "BankAccountId");

                    b.HasOne("P01_BillsPaymentSystem.Data.Models.CreditCard", "CreditCard")
                        .WithOne("PaymentMethod")
                        .HasForeignKey("P01_BillsPaymentSystem.Data.Models.PaymentMethod", "CreditCardId");

                    b.HasOne("P01_BillsPaymentSystem.Data.Models.User", "User")
                        .WithMany("PaymentMethods")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
