namespace P03_FootballBetting.Data.Config
{
    using System;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Models;

    public class BetConfig : IEntityTypeConfiguration<Bet>
    {
        public void Configure(EntityTypeBuilder<Bet> builder)
        {
            builder.HasKey(e => e.BetId);

            builder.Property(e => e.Prediction)
                .IsRequired(true);

            builder.Property(e => e.DateTime)
                .HasDefaultValue(DateTime.Now);

            builder.Property(e => e.UserId)
                .IsRequired(true);

            builder.HasOne(e => e.User)
                .WithMany(u => u.Bets)
                .HasForeignKey(e => e.UserId);

            builder.Property(e => e.GameId)
                .IsRequired(true);

            builder.HasOne(e => e.Game)
                .WithMany(g => g.Bets)
                .HasForeignKey(e => e.GameId);
        }
    }
}
