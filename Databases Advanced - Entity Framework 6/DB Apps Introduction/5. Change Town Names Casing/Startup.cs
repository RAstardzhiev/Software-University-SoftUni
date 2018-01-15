namespace _5.Change_Town_Names_Casing
{
    using System;
    using System.Collections.Generic;
    using System.Data.SqlClient;
    using System.IO;
    using System.Text;

    public class Startup
    {
        private const string ConnectionString = @"
                    Server=DESKTOP-5FMQC2G\SQLEXPRESS; 
                    Database=MinionsDB; 
                    Integrated Security=true;";
        private const string UpdateTownsNamesByCountryQueryPath = @"..\..\Update Towns by country query.sql";
        private const string SelectTownsByCountryQueryPath = @"..\..\Select Towns by Country query.sql";

        public static void Main()
        {
            Console.Write("Enter a country name: ");
            string countryName = Console.ReadLine();

            if (!TryMakeTownsToUpper(countryName))
            {
                Console.WriteLine("No town names were affected.");
            }
        }

        private static bool TryMakeTownsToUpper(string countryName)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                string cmdText = File.ReadAllText(UpdateTownsNamesByCountryQueryPath);
                using (SqlCommand command = new SqlCommand(cmdText, connection))
                {
                    command.Parameters.AddWithValue("@countryName", countryName);
                    int numberOfAffectedRows = command.ExecuteNonQuery();
                    if (numberOfAffectedRows == 0)
                    {
                        return false;
                    }
                }

                PrintTownsByCountry(countryName, connection);
            }

            return true;
        }

        private static void PrintTownsByCountry(string countryName, SqlConnection connection)
        {
            string cmdText = File.ReadAllText(SelectTownsByCountryQueryPath);
            using (SqlCommand command = new SqlCommand(cmdText, connection))
            {
                command.Parameters.AddWithValue("@countryName", countryName);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    IEnumerable<string> townsNames = ReaderToCollection(reader, 0);
                    Console.WriteLine($"[{string.Join(", ", townsNames)}]");
                }
            }
        }

        private static IEnumerable<string> ReaderToCollection(SqlDataReader reader, int columnIndex)
        {
            while (reader.Read())
            {
                yield return reader.GetString(columnIndex);
            }
        }
    }
}
