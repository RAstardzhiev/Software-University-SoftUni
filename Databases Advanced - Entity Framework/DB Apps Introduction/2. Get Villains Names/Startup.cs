namespace _2.Get_Villains_Names
{
    using System;
    using System.Data.SqlClient;
    using System.IO;

    public class Startup
    {
        public static void Main()
        {
            SqlConnection connection = new SqlConnection($@"
                Server=DESKTOP-5FMQC2G\SQLEXPRESS; 
                Database=MinionsDB; 
                Integrated Security=true;");

            connection.Open();

            using (connection)
            {
                string cmdText = File.ReadAllText(@"..\..\Minions Per Villain.sql");
                SqlCommand command = new SqlCommand(cmdText, connection);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        Console.Write($"{reader.GetName(i), -20}");
                    }
                    
                    Console.WriteLine();

                    while (reader.Read())
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            Console.Write($"{reader[i], -20}");
                        }

                        Console.WriteLine();
                    }
                }
            }
        }
    }
}
