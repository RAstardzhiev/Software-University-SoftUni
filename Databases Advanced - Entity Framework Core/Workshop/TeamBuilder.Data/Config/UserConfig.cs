namespace TeamBuilder.Data.Config
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using TeamBuilder.Models;
    using TeamBuilder.Models.Helpers;

    public class UserConfig : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(e => e.Id);

            builder.HasAlternateKey(e => e.Username);

            builder.Property(e => e.Username)
                .HasMaxLength(Constants.UsernameMaxLength);

            builder.Property(e => e.FirstName)
                .HasMaxLength(Constants.UserFirstNameMaxLength);

            builder.Property(e => e.LastName)
                .HasMaxLength(Constants.UserLastNameMaxLength);

            builder.Property(e => e.Password)
                .HasMaxLength(Constants.PasswordMaxLength)
                .IsRequired(true);
        }
    }
}
