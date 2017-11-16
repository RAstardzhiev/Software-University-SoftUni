namespace P03_FootballBetting.Data.Config
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Models;

    public class UserConfig : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(e => e.UserId);

            builder.Property(e => e.Username)
                .IsUnicode(true)
                .IsRequired(true);

            builder.Property(e => e.Password)
                .IsUnicode(false)
                .IsRequired(true);

            builder.Property(e => e.Email)
                .IsUnicode(false)
                .IsRequired(true);

            builder.Property(e => e.Name)
                .IsUnicode(true)
                .IsRequired(true);
        }
    }
}
