namespace P03_FootballBetting.Data.Config
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Models;

    public class GameConfig : IEntityTypeConfiguration<Game>
    {
        public void Configure(EntityTypeBuilder<Game> builder)
        {
            builder.HasKey(e => e.GameId);

            builder.HasOne(e => e.HomeTeam)
                .WithMany(t => t.HomeGames)
                .HasForeignKey(e => e.GameId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(e => e.AwayTeam)
                .WithMany(t => t.AwayGames)
                .HasForeignKey(e => e.AwayTeamId);
        }
    }
}
