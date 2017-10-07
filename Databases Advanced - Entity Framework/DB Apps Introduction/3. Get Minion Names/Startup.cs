namespace _3.Get_Minion_Names
{
    using System;
    using System.Data.SqlClient;
    using System.IO;

    public class Startup
    {
        public static void Main()
        {
            Console.Write("Enter a Villain ID: ");
            int villainId = int.Parse(Console.ReadLine());

            SqlConnection connection = new SqlConnection($@"
                Server=DESKTOP-5FMQC2G\SQLEXPRESS; 
                Database=MinionsDB; 
                Integrated Security=true;");

            connection.Open();
            string cmdText = string.Format(File.ReadAllText(@"..\..\Selection query.sql"), villainId);

            using (connection)
            {
                SqlCommand command = new SqlCommand(cmdText, connection);
                command.Parameters.AddWithValue("@villainId", villainId);
;
                SqlDataReader reader = command.ExecuteReader();

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
}
