namespace PetClinic.Data
{
    using Microsoft.EntityFrameworkCore;
    using PetClinic.Models;

    public class PetClinicContext : DbContext
    {
        public PetClinicContext() { }

        public PetClinicContext(DbContextOptions options)
            :base(options) { }

        public DbSet<Animal> Animals { get; set; }
        public DbSet<AnimalAid> AnimalAids { get; set; }
        public DbSet<Passport> Passports { get; set; }
        public DbSet<Procedure> Procedures { get; set; }
        public DbSet<ProcedureAnimalAid> ProceduresAnimalAids { get; set; }
        public DbSet<Vet> Vets { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(Configuration.ConnectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Vet>()
                .HasAlternateKey(e => e.PhoneNumber);

            builder.Entity<Procedure>()
                .Ignore(e => e.Cost);

            builder.Entity<AnimalAid>()
                .HasAlternateKey(e => e.Name);

            builder.Entity<ProcedureAnimalAid>()
                .HasKey(e => new { e.AnimalAidId, e.ProcedureId });

            builder.Entity<ProcedureAnimalAid>()
                .HasOne(e => e.AnimalAid)
                .WithMany(a => a.AnimalAidProcedures)
                .HasForeignKey(e => e.AnimalAidId);

            builder.Entity<ProcedureAnimalAid>()
                .HasOne(e => e.Procedure)
                .WithMany(p => p.ProcedureAnimalAids)
                .HasForeignKey(e => e.ProcedureId);

            builder.Entity<Animal>()
                .HasOne(e => e.Passport)
                .WithOne(p => p.Animal)
                .HasForeignKey<Animal>(e => e.PassportSerialNumber);
        }
    }
}
