namespace _1.Initial_Setup
{
    using System.Data.SqlClient;
    using System.IO;

    public class Startup
    {
        public static void Main()
        {
            string dbName = "MinionsDB";
            string serverName = @"DESKTOP-5FMQC2G\SQLEXPRESS";
            string authentication = "Integrated Security=true";
            CreateDatabase(dbName, serverName, authentication);

            SqlConnection connection = new SqlConnection($@"
                Server={serverName}; 
                Database={dbName}; 
                {authentication};");

            connection.Open();
            string cmdText = File.ReadAllText(@"..\..\Tables Data.sql");
            SqlCommand command = new SqlCommand(cmdText, connection);
            using (connection)
            {
                command.ExecuteNonQuery();
            }
        }

        private static void CreateDatabase(string dbName, string serverName, string authentication)
        {
            SqlConnection connection = new SqlConnection($@"
                Server={serverName}; 
                Database=master; 
                {authentication};");

            connection.Open();

            using (connection)
            {
                SqlCommand command = new SqlCommand($@"
                CREATE DATABASE {dbName};",
                connection);

                command.ExecuteNonQuery();
            }
        }
    }
}
