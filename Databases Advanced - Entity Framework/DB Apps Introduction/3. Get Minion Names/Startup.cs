namespace _3.Get_Minion_Names
{
    using System;
    using System.Data.SqlClient;
    using System.IO;

    public class Startup
    {
        private const string ConnectionString = @"
            Server=DESKTOP-5FMQC2G\SQLEXPRESS; 
            Database=MinionsDB; 
            Integrated Security=true;";
        private const string SelectionQueryPath = @"..\..\Selection query.sql";

        public static void Main()
        {
            Console.Write("Enter a Villain ID: ");
            int villainId = int.Parse(Console.ReadLine());

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                string cmdText = string.Format(File.ReadAllText(SelectionQueryPath), villainId);
                using (SqlCommand command = new SqlCommand(cmdText, connection))
                {
                    command.Parameters.AddWithValue("@villainId", villainId);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        ProcessSelection(reader, villainId);
                    }
                }
            }
        }

        private static void ProcessSelection(SqlDataReader reader, int villainId)
        {
            if (reader.HasRows)
            {
                reader.Read();
                Console.WriteLine($"Villain: {reader["VillainName"]}");

                if (reader.IsDBNull(1))
                {
                    Console.WriteLine("(no minions)");
                }
                else
                {
                    int minionNumber = 1;
                    while (true)
                    {
                        Console.WriteLine($"{minionNumber++}. {reader["MinionName"]} {reader["MinionAge"]}");

                        if (!reader.Read())
                        {
                            break;
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine($"No villain with ID {villainId} exists in the database.");
            }
        }
    }
}
