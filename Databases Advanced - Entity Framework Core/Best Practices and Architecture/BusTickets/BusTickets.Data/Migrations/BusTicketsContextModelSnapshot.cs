namespace BusTickets.Data.Migrations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Infrastructure;
    using Microsoft.EntityFrameworkCore.Metadata;
    using System;

    [DbContext(typeof(BusTicketsContext))]
    partial class BusTicketsContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BusTickets.Models.BankAccount", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AccountNumber")
                        .IsRequired()
                        .HasMaxLength(30)
                        .IsUnicode(false);

                    b.Property<decimal>("Balance");

                    b.Property<int>("CustomerId");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("BankAccounts");
                });

            modelBuilder.Entity("BusTickets.Models.BusCompany", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CountryId");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(true);

                    b.Property<double?>("Rating");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("BusCompanies");
                });

            modelBuilder.Entity("BusTickets.Models.BusStation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(true);

                    b.Property<int>("TownId");

                    b.HasKey("Id");

                    b.HasIndex("TownId");

                    b.ToTable("BusStations");
                });

            modelBuilder.Entity("BusTickets.Models.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .IsUnicode(true);

                    b.HasKey("Id");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("BusTickets.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("DateOfBirth");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .IsUnicode(true);

                    b.Property<string>("Gender")
                        .HasColumnType("CHAR(1)");

                    b.Property<int>("HomeTownId");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .IsUnicode(true);

                    b.HasKey("Id");

                    b.HasIndex("HomeTownId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("BusTickets.Models.Review", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("BusCompanyId");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(true);

                    b.Property<int>("CustomerId");

                    b.Property<double>("Grade");

                    b.Property<DateTime>("PublishDate")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("GETDATE()");

                    b.HasKey("Id");

                    b.HasIndex("BusCompanyId");

                    b.HasIndex("CustomerId");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("BusTickets.Models.Ticket", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CustomerId");

                    b.Property<decimal>("Price");

                    b.Property<string>("Seat")
                        .IsRequired()
                        .HasMaxLength(5)
                        .IsUnicode(false);

                    b.Property<int>("TripId");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("TripId");

                    b.ToTable("Tickets");
                });

            modelBuilder.Entity("BusTickets.Models.Town", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CountryId");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(true);

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("Towns");
                });

            modelBuilder.Entity("BusTickets.Models.Trip", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("ArrivalTime");

                    b.Property<int>("BusCompanyId");

                    b.Property<DateTime>("DepartureTime");

                    b.Property<int>("DestinationBusStationId");

                    b.Property<int>("OriginBusStationId");

                    b.Property<int?>("Status");

                    b.HasKey("Id");

                    b.HasIndex("BusCompanyId");

                    b.HasIndex("DestinationBusStationId");

                    b.HasIndex("OriginBusStationId");

                    b.ToTable("Trips");
                });

            modelBuilder.Entity("BusTickets.Models.BankAccount", b =>
                {
                    b.HasOne("BusTickets.Models.Customer", "Customer")
                        .WithMany("BankAccounts")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BusTickets.Models.BusCompany", b =>
                {
                    b.HasOne("BusTickets.Models.Country", "Country")
                        .WithMany("BusCompanies")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BusTickets.Models.BusStation", b =>
                {
                    b.HasOne("BusTickets.Models.Town", "Town")
                        .WithMany("BusStations")
                        .HasForeignKey("TownId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BusTickets.Models.Customer", b =>
                {
                    b.HasOne("BusTickets.Models.Town", "HomeTown")
                        .WithMany("Customers")
                        .HasForeignKey("HomeTownId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BusTickets.Models.Review", b =>
                {
                    b.HasOne("BusTickets.Models.BusCompany", "BusCompany")
                        .WithMany("Reviews")
                        .HasForeignKey("BusCompanyId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("BusTickets.Models.Customer", "Customer")
                        .WithMany("Reviews")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("BusTickets.Models.Ticket", b =>
                {
                    b.HasOne("BusTickets.Models.Customer", "Customer")
                        .WithMany("Tickets")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("BusTickets.Models.Trip", "Trip")
                        .WithMany("Tickets")
                        .HasForeignKey("TripId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("BusTickets.Models.Town", b =>
                {
                    b.HasOne("BusTickets.Models.Country", "Country")
                        .WithMany("Towns")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BusTickets.Models.Trip", b =>
                {
                    b.HasOne("BusTickets.Models.BusCompany", "BusCompany")
                        .WithMany("Trips")
                        .HasForeignKey("BusCompanyId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("BusTickets.Models.BusStation", "DestinationBusStation")
                        .WithMany("ArrivingTrips")
                        .HasForeignKey("DestinationBusStationId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("BusTickets.Models.BusStation", "OriginBusStation")
                        .WithMany("StartingTrips")
                        .HasForeignKey("OriginBusStationId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
