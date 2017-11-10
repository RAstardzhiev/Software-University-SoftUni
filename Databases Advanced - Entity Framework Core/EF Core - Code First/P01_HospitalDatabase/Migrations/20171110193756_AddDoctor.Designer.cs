namespace P01_HospitalDatabase.Migrations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Infrastructure;
    using Microsoft.EntityFrameworkCore.Metadata;
    using Microsoft.EntityFrameworkCore.Migrations;
    using P01_HospitalDatabase.Data;
    using System;

    [DbContext(typeof(HospitalContext))]
    [Migration("20171110193756_AddDoctor")]
    partial class AddDoctor
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("P01_HospitalDatabase.Data.Models.Diagnose", b =>
                {
                    b.Property<int>("DiagnoseId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Comments")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue("Healthy :)")
                        .HasMaxLength(250)
                        .IsUnicode(true);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(true);

                    b.Property<int>("PatientId");

                    b.HasKey("DiagnoseId");

                    b.HasIndex("PatientId");

                    b.ToTable("Diagnoses");
                });

            modelBuilder.Entity("P01_HospitalDatabase.Data.Models.Doctor", b =>
                {
                    b.Property<int>("DoctorId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(true);

                    b.Property<string>("Specialty")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(true);

                    b.HasKey("DoctorId");

                    b.ToTable("Doctors");
                });

            modelBuilder.Entity("P01_HospitalDatabase.Data.Models.Medicament", b =>
                {
                    b.Property<int>("MedicamentId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(true);

                    b.HasKey("MedicamentId");

                    b.ToTable("Medicaments");
                });

            modelBuilder.Entity("P01_HospitalDatabase.Data.Models.Patient", b =>
                {
                    b.Property<int>("PatientId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(250)
                        .IsUnicode(true);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(80)
                        .IsUnicode(false);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(true);

                    b.Property<bool>("HasInsurance");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(true);

                    b.HasKey("PatientId");

                    b.ToTable("Patients");
                });

            modelBuilder.Entity("P01_HospitalDatabase.Data.Models.PatientMedicament", b =>
                {
                    b.Property<int>("PatientId");

                    b.Property<int>("MedicamentId");

                    b.HasKey("PatientId", "MedicamentId");

                    b.HasIndex("MedicamentId");

                    b.ToTable("PatientsMedicaments");
                });

            modelBuilder.Entity("P01_HospitalDatabase.Data.Models.Visitation", b =>
                {
                    b.Property<int>("VisitationId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Comments")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue("OK")
                        .HasMaxLength(250)
                        .IsUnicode(true);

                    b.Property<DateTime>("Date")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<int?>("DoctorId");

                    b.Property<int>("PatientId");

                    b.HasKey("VisitationId");

                    b.HasIndex("DoctorId");

                    b.HasIndex("PatientId");

                    b.ToTable("Visitations");
                });

            modelBuilder.Entity("P01_HospitalDatabase.Data.Models.Diagnose", b =>
                {
                    b.HasOne("P01_HospitalDatabase.Data.Models.Patient", "Patient")
                        .WithMany("Diagnoses")
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("P01_HospitalDatabase.Data.Models.PatientMedicament", b =>
                {
                    b.HasOne("P01_HospitalDatabase.Data.Models.Medicament", "Medicament")
                        .WithMany("Prescriptions")
                        .HasForeignKey("MedicamentId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("P01_HospitalDatabase.Data.Models.Patient", "Patient")
                        .WithMany("Prescriptions")
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("P01_HospitalDatabase.Data.Models.Visitation", b =>
                {
                    b.HasOne("P01_HospitalDatabase.Data.Models.Doctor", "Doctor")
                        .WithMany("Visitations")
                        .HasForeignKey("DoctorId");

                    b.HasOne("P01_HospitalDatabase.Data.Models.Patient", "Patient")
                        .WithMany("Visitations")
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
