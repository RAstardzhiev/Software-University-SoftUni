namespace _8.Create_User
{
    using System.Data.Entity;
    using Models;

    public class CreateUserContext : DbContext
    {
        public CreateUserContext()
            : base("name=CreateUserContext")
        {
        }

        public DbSet<User> Users { get; set; }
    }
}