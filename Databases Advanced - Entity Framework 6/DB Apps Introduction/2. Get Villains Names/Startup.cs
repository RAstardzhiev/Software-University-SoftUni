namespace _2.Get_Villains_Names
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

        public static void Main()
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                string cmdText = File.ReadAllText(@"..\..\Minions Per Villain.sql");
                using (SqlCommand command = new SqlCommand(cmdText, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                Console.Write($"{reader.GetName(i),-20}");
                            }

                            Console.WriteLine();

                            while (reader.Read())
                            {
                                for (int i = 0; i < reader.FieldCount; i++)
                                {
                                    Console.Write($"{reader[i],-20}");
                                }

                                Console.WriteLine();
                            }
                        }
                    }
                }
            }
        }
    }
}
