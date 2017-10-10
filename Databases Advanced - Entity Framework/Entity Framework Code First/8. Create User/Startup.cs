namespace _8.Create_User
{
    using System.IO;

    public class Startup
    {
        private const string UsersDataInsertionQueryPath = @"..\..\UsersDataInsertion.sql";
        public static void Main()
        {
            using (CreateUserContext context = new CreateUserContext())
            {
                context.Database.Initialize(true);

                var cmdText = File.ReadAllText(UsersDataInsertionQueryPath);
                var test = context.Database.ExecuteSqlCommand(cmdText);
            }
        }
    }
}
