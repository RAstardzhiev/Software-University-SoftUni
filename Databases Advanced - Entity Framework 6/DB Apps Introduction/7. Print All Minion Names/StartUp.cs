namespace _7.Print_All_Minion_Names
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
        private const string MinionsNamesSelectionQueryPath = @"..\..\Minions names selection query.sql";

        public static void Main()
        {
            IEnumerable<string> allMinionsNames = GetAllMinionNames();
            PrintNamesInSpecialOrder(allMinionsNames.ToArray());
        }

        private static void PrintNamesInSpecialOrder(string[] minionsNames)
        {
            for (int first = 0, last = minionsNames.Length - 1; first <= last; first++, last--)
            {
                Console.WriteLine(minionsNames[first]);
                if (first != last)
                {
                    Console.WriteLine(minionsNames[last]);
                }
            }
        }

        private static IEnumerable<string> GetAllMinionNames()
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                string cmdText = File.ReadAllText(MinionsNamesSelectionQueryPath);
                using (SqlCommand command = new SqlCommand(cmdText, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            yield return reader.GetString(0);
                        }
                    }
                }
            }
        }
    }
}
