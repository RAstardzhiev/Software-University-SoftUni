namespace StudentSystem_Startup
{
    using Microsoft.EntityFrameworkCore;
    using P01_StudentSystem.Data;

    public class Startup
    {
        public static void Main()
        {
            using (var context = new StudentSystemContext())
            {
                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();
                context.Database.Migrate();
            }
        }
    }
}
