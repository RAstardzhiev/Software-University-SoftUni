namespace P03_FootballBetting.Data
{
    using Microsoft.EntityFrameworkCore;
    using Config;
    using Models;

    public class FootballBettingContext : DbContext
    {

        public FootballBettingContext()
        {
        }

        public FootballBettingContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<Team> Teams { get; set; }
        
        public DbSet<Color> Colors { get; set; }

        public DbSet<Town> Towns { get; set; }

        public DbSet<Country> Countries { get; set; }

        public DbSet<Player> Players { get; set; }

        public DbSet<Position> Positions { get; set; }

        public DbSet<PlayerStatistic> PlayerStatistics { get; set; }

        public DbSet<Bet> Bets { get; set; }

        public DbSet<Game> Games { get; set; }

        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(DbContextConfiguration.ConnectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new TeamConfig());
            modelBuilder.ApplyConfiguration(new ColorConfig());
            modelBuilder.ApplyConfiguration(new TownConfig());
            modelBuilder.ApplyConfiguration(new CountryConfig());
            modelBuilder.ApplyConfiguration(new PlayerConfig());
            modelBuilder.ApplyConfiguration(new PositionConfig());
            modelBuilder.ApplyConfiguration(new PlayerStatisticConfig());
            modelBuilder.ApplyConfiguration(new GameConfig());
            modelBuilder.ApplyConfiguration(new BetConfig());
            modelBuilder.ApplyConfiguration(new UserConfig());
        }
    }
}
