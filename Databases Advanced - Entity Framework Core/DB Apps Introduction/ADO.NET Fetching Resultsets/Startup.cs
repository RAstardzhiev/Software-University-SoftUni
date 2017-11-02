namespace ADO.NET_Fetching_Resultsets
{
    using System.Data.SqlClient;

    public class Startup
    {
        /* SQLDataProvider Installation Guide
                Open: Package Manager Console
                Type: Install-Package System.Data.SQLClient
                Press: Enter
                Ready. :)
         */

        private const string InitialConnectionString = @"
            Server=DESKTOP-5FMQC2G\SQLEXPRESS;
            Integrated Security=true";
        /* Same result as this one
        private const string InitialConnectionString = @"
            Server=DESKTOP-5FMQC2G\SQLEXPRESS;
            Database=master;
            Integrated Security=true";
         */

        private const string MinionsDBConnectionString = @"
            Server=DESKTOP-5FMQC2G\SQLEXPRESS;
            Database=MinionsDB;
            Integrated Security=true";

        public static void Main()
        {
            var exercises = new Exercises();
            // exercises.InitialSetup(InitialConnectionString); // 1. Initial Setup
            // exercises.VillainNames(MinionsDBConnectionString); // 2. Villain Names
            // exercises.MinionNames(MinionsDBConnectionString); // 3. Minion Names
            // exercises.AddMinion(MinionsDBConnectionString); // 4. Add Minion
            // exercises.ChangeTownNamesCasing(MinionsDBConnectionString); // 5. Change Town Names Casing
            exercises.RemoveVillain(MinionsDBConnectionString); // 6. *Remove Villain 
        }
    }
}
