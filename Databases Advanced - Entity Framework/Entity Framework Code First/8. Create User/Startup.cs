namespace _8.Create_User
{
    using System;
    using System.Data.SqlClient;
    using System.IO;
    using System.Linq;

    public class Startup
    {
        private const string GetUsersByEmailProviderUserLeadingToEnterTargetEmailEndMessage = "Enter on what you expect to end the emails: ";
        private const string DeleteUsersWitLastLoginBeforeDateGetDateMessage = "Each user before the entered date will be deleted. Enter date:";
        private const string MarkAsDeletedUsersMessageWhenAtLeastOneIsMarked = "{0} users have been deleted";
        private const string MarkAsDeletedUsersMessageWhenNoOneIsMarked = "No users have been deleted";
        private const string DeleteAllMarkedUsersMessage = "{0} permanently removed from database";

        private const string UsersDataInsertionQueryPath = @"..\..\SQL queries\Users Data Insertion.sql";
        private const string GetUsersByEmailProviderSqlQueryPath = @"..\..\SQL queries\Username Email selection by email ends with.sql";
        private const string GetUsersByEmailProviderParameterName = "@endsWith";
        private const string MarkAsDeletedUserWithLoginBeforeDateQueryPath = @"..\..\SQL queries\Mark as deleted users with last login before date.sql";
        private const string MarkAsDeletedUserWithLoginBeforeDateParameterName = "@deletionsBefore";
        private const string DeleteAllMarkedUsersQueryPath = @"..\..\SQL queries\Delete all marked users.sql";


        public static void Main()
        {
            using (CreateUserContext context = new CreateUserContext())
            {
                // CreateUser(context); // 8. Create User
                // GetUsersByEmailProvider(context); // 11. Get Users by Email Provider
                // RemoveInactiveUsers(context); // 12. Remove Inactive Users
            }
        }

        private static void RemoveInactiveUsers(CreateUserContext context)
        {
            Console.WriteLine(DeleteUsersWitLastLoginBeforeDateGetDateMessage);
            var deleteBefore = Console.ReadLine();

            // Mark users as deleted
            var markCmdText = File.ReadAllText(MarkAsDeletedUserWithLoginBeforeDateQueryPath);
            var markAffectedRows = context.Database.ExecuteSqlCommand(markCmdText, 
                new SqlParameter(MarkAsDeletedUserWithLoginBeforeDateParameterName, deleteBefore));

            Console.WriteLine((markAffectedRows > 0) 
                ? string.Format(MarkAsDeletedUsersMessageWhenAtLeastOneIsMarked, markAffectedRows) 
                : MarkAsDeletedUsersMessageWhenNoOneIsMarked);

            // Delete all marked users
            var deleteCmdText = File.ReadAllText(DeleteAllMarkedUsersQueryPath);
            var deleteAffectedRows = context.Database.ExecuteSqlCommand(deleteCmdText);
            Console.WriteLine(string.Format(DeleteAllMarkedUsersMessage, deleteAffectedRows));
        }

        private static void GetUsersByEmailProvider(CreateUserContext context)
        {
            Console.Write(GetUsersByEmailProviderUserLeadingToEnterTargetEmailEndMessage);
            var emailEndsWith = Console.ReadLine();

            var cmdText = File.ReadAllText(GetUsersByEmailProviderSqlQueryPath);
            var selectedResult = context.Database.SqlQuery<string>(
                cmdText, new SqlParameter(GetUsersByEmailProviderParameterName, emailEndsWith)).ToList();

            Console.WriteLine(string.Join(Environment.NewLine, selectedResult));
        }

        private static void CreateUser(CreateUserContext context)
        {
            context.Database.Initialize(true);

            var cmdText = File.ReadAllText(UsersDataInsertionQueryPath);
            var affectedRows = context.Database.ExecuteSqlCommand(cmdText);
            Console.WriteLine(affectedRows);
        }
    }
}
