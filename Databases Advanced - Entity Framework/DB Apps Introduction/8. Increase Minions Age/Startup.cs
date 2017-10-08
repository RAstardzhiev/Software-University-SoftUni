namespace _8.Increase_Minions_Age
{
    using System;
    using System.Collections.Generic;
    using System.Data.SqlClient;
    using System.IO;
    using System.Linq;

    public class Startup
    {
        private const string ConnectionString = @"
                    Server=DESKTOP-5FMQC2G\SQLEXPRESS; 
                    Database=MinionsDB; 
                    Integrated Security=true;";
        private const string MinionsNamesToTilteAndAgePlusOneQueryPath = @"..\..\Minion names to title Age++ query.sql";

        public static void Main()
        {
            IEnumerable<int> minionsIds = Console.ReadLine()
                .Split(new char[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                string cmdText = File.ReadAllText(MinionsNamesToTilteAndAgePlusOneQueryPath)
                    .Replace("@idCollection", string.Join(", ", minionsIds));
                using (SqlCommand command = new SqlCommand(cmdText, connection))
                {
                    int rowsAffected = command.ExecuteNonQuery();
                    Console.WriteLine($"Affected rows: {rowsAffected}");
                }
            }
        }
    }
}
