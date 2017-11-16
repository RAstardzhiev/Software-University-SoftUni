namespace P03_FootballBetting.App
{
    using Microsoft.EntityFrameworkCore;
    using P03_FootballBetting.Data;

    public class Startup
    {
        public static void Main()
        {
            using (var context = new FootballBettingContext())
            {
                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();
                context.Database.Migrate();
            }
        }
    }
}
