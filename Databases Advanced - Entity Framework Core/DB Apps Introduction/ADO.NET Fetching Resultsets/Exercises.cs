namespace ADO.NET_Fetching_Resultsets
{
    using System;
    using System.Data.SqlClient;
    using System.IO;
    using System.Linq;
    using System.Text;

    public class Exercises
    {
        private const string DBCreationFilePath = @"SQL/CreateDatabase.sql";
        private const string TablesCreationFilePath = @"SQL/CreateTables.sql";
        private const string CountMinionsByVillainsFilePath = @"SQL/CountMinionsByVillains.sql";
        private const string SelectVillainByIdFilePath = @"SQL/SelectVillainById.sql";
        private const string SelectMinionsByVillainFilePath = @"SQL/SelectMinionsByVillain.sql";
        private const string SelectMinionIdByNameFilePath = @"SQL/SelectMinionIdByName.sql";
        private const string SelectTownIdByNameFilePath = @"SQL/SelectTownIdByName.sql";
        private const string InsertTownFilePath = @"SQL/InsertTown.sql";
        private const string SelectLastInsertedIdFilePath = @"SQL/SelectLastInsertedId.sql";
        private const string InsertMinionFilePath = @"SQL/InsertMinion.sql";
        private const string SelectVillainIdByNameFilePath = @"SQL/SelectVillainIdByName.sql";
        private const string InsertVillainFilePath = @"SQL/InsertVillain.sql";
        private const string AddMinionToVillainFilePath = @"SQL/AddMinionToVillain.sql";
        private const string UpdateTownsNamesByCountryFilePath = @"SQL/UpdateTownsNamesByCountry.sql";
        private const string SelectTownsNamesFromCountryFilePath = @"SQL/SelectTownsNamesFromCountry.sql";

        internal void InitialSetup(string connectionString) // 1. Initial Setup
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                this.ExecuteNonQueryCommand(connection, DBCreationFilePath); // Create Database
                this.ExecuteNonQueryCommand(connection, TablesCreationFilePath); // Create Tables
            }
        }

        internal void VillainNames(string connectionString) // 2. Villain Names
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var cmdText = File.ReadAllText(CountMinionsByVillainsFilePath);
                using (var command = new SqlCommand(cmdText, connection))
                {
                    command.ExecuteNonQuery();
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                Console.WriteLine($"{reader["Villain Name"]} - {reader["Number of Minions"]}");
                            }
                        }
                    }
                }
            }
        }

        internal void MinionNames(string minionsDBConnectionString) // 3. Minion Names
        {
            var villainId = int.Parse(Console.ReadLine());

            using (var connection = new SqlConnection(minionsDBConnectionString))
            {
                connection.Open();
                this.PrintVillainName(connection, villainId);
                this.PrintMinionsServingToVillain(connection, villainId);
            }
        }

        internal void AddMinion(string minionsDBConnectionString) // 4. Add Minion
        {
            using (var connection = new SqlConnection(minionsDBConnectionString))
            {
                connection.Open();
                var transaction = connection.BeginTransaction();

                try
                {
                    var minoonDetails = Console.ReadLine().Split().Skip(1).ToArray();
                    var minionName = minoonDetails[0];
                    var minionAge = int.Parse(minoonDetails[1]);
                    var townName = minoonDetails[2];
                    var minionId = this.GetMinionId(connection, transaction, minionName, minionAge, townName);
                    
                    var villainDetails = Console.ReadLine().Split().Skip(1).ToArray();
                    var villainName = villainDetails[0];
                    var evilnessFactor = villainDetails.Length > 1
                        ? villainDetails[1]
                        : "Evil";

                    var villainId = this.GetVillainId(connection, transaction, villainName, evilnessFactor);
                    this.AddMinionToVillain(connection, transaction, minionId, villainId);
                    Console.WriteLine($"Successfully added {minionName} to be minion of {villainName}.");
                    transaction.Commit();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    transaction.Rollback();
                }
            }
        }

        internal void ChangeTownNamesCasing(string minionsDBConnectionString) // 5. Change Town Names Casing
        {
            var affectedRows = 0;
            var countryName = Console.ReadLine();
            using (var connection = new SqlConnection(minionsDBConnectionString))
            {
                connection.Open();
                var cmdText = File.ReadAllText(UpdateTownsNamesByCountryFilePath);
                using (var command = new SqlCommand(cmdText, connection))
                {
                    command.Parameters.AddWithValue("@countryName", countryName);
                    affectedRows = command.ExecuteNonQuery();
                }

                if (affectedRows > 0)
                {
                    Console.WriteLine($"{affectedRows} town names were affected.");
                    this.PrintTownsnamesFromCountry(connection, countryName);
                }
                else
                {
                    Console.WriteLine("No town names were affected.");
                }
            }
        }

        internal void RemoveVillain(string minionsDBConnectionString) // 6. *Remove Villain 
        {
             throw new NotImplementedException();
        }

        private void PrintTownsnamesFromCountry(SqlConnection connection, string countryName)
        {
            var towns = string.Empty;
            var cmdText = File.ReadAllText(SelectTownsNamesFromCountryFilePath);
            using (var command = new SqlCommand(cmdText, connection))
            {
                command.Parameters.AddWithValue("@countryName", countryName);
                using (var reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        var sb = new StringBuilder();
                        sb.Append("[");

                        while (reader.Read())
                        {
                            sb.Append($"{reader[0]}, ");
                        }

                        towns = sb
                            .Remove(sb.Length - 2, 2)
                            .Append("]")
                            .ToString();
                    }
                }
            }

            Console.WriteLine(towns);
        }

        private void AddMinionToVillain(SqlConnection connection, SqlTransaction transaction, int minionId, int villainId)
        {
            var cmdText = File.ReadAllText(AddMinionToVillainFilePath);
            using (var command = new SqlCommand(cmdText, connection, transaction))
            {
                command.Parameters.AddWithValue("@minionId", minionId);
                command.Parameters.AddWithValue("@villainId", villainId);
                command.ExecuteNonQuery();
            }
        }

        private int GetVillainId(SqlConnection connection, SqlTransaction transaction, string name, string evilnessFactor)
        {
            var cmdText = File.ReadAllText(SelectVillainIdByNameFilePath);
            using (var command = new SqlCommand(cmdText, connection, transaction))
            {
                command.Parameters.AddWithValue("@name", name);
                var id = command.ExecuteScalar();
                if (id == null)
                {
                    return this.InsertVillain(connection, transaction, name, evilnessFactor);
                }

                return int.Parse((string)id);
            }
        }

        private int InsertVillain(SqlConnection connection, SqlTransaction transaction, string name, string evilnessFactor)
        {
            var cmdText = File.ReadAllText(InsertVillainFilePath);
            using (var command = new SqlCommand(cmdText, connection, transaction))
            {
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@evilnessFactor", evilnessFactor);
                command.ExecuteNonQuery();
            }

            Console.WriteLine($"Villain {name} was added to the database.");
            return this.GetLastInsertedId(connection, transaction, "Villains");
        }

        private int GetMinionId(SqlConnection connection, SqlTransaction transaction, string name, int age, string townName)
        {
            var existingIdCmdText = File.ReadAllText(SelectMinionIdByNameFilePath);
            using (var command = new SqlCommand(existingIdCmdText, connection, transaction))
            {
                command.Parameters.AddWithValue("@name", name);

                var commandResult = command.ExecuteScalar();
                if (commandResult == null)
                {
                    return this.InsertMinion(connection, transaction, name, age, townName);
                }

                return int.Parse((string)commandResult);
            }
        }

        private int InsertMinion(SqlConnection connection, SqlTransaction transaction, string name, int age, string townName)
        {
            var townId = this.GetTownId(connection, transaction, townName);
            var cmdText = File.ReadAllText(InsertMinionFilePath);
            using (var command = new SqlCommand(cmdText, connection, transaction))
            {
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@age", age);
                command.Parameters.AddWithValue("@townId", townId);

                command.ExecuteNonQuery();
            }

            Console.WriteLine($"Minion {name} was added to the database.");
            return this.GetLastInsertedId(connection, transaction, "Minions");
        }

        private int GetTownId(SqlConnection connection, SqlTransaction transaction, string townName)
        {
            var cmdText = File.ReadAllText(SelectTownIdByNameFilePath);
            using (var command = new SqlCommand(cmdText, connection, transaction))
            {
                command.Parameters.AddWithValue("@name", townName);
                var commandResult = command.ExecuteScalar();
                if (commandResult == null)
                {
                   return this.InsertTown(connection, transaction, townName);
                }

                return int.Parse((string)commandResult);
            }
        }

        private int InsertTown(SqlConnection connection, SqlTransaction transaction, string townName)
        {
            var cmdText = File.ReadAllText(InsertTownFilePath);
            using (var command = new SqlCommand(cmdText, connection, transaction))
            {
                command.Parameters.AddWithValue("@townName", townName);
                command.ExecuteNonQuery();
            }

            Console.WriteLine($"Town {townName} was added to the database.");
            return this.GetLastInsertedId(connection, transaction, "Towns");
        }

        private int GetLastInsertedId(SqlConnection connection, SqlTransaction transaction, string tableName)
        {
            var cmdText = File.ReadAllText(SelectLastInsertedIdFilePath);
            using (var command = new SqlCommand(cmdText, connection, transaction))
            {
                command.Parameters.AddWithValue("@tableName", tableName);
                return int.Parse((string)command.ExecuteScalar());
            }
        }

        private void PrintMinionsServingToVillain(SqlConnection connection, int villainId)
        {
            var cmdText = File.ReadAllText(SelectMinionsByVillainFilePath);
            using (var command = new SqlCommand(cmdText, connection))
            {
                command.Parameters.AddWithValue("@villainId", villainId);

                using (var reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        var minionNumber = 1;

                        while (reader.Read())
                        {
                            Console.WriteLine($"{minionNumber++}. {reader["Name"]} {reader["Age"]}");
                        }
                    }
                    else
                    {
                        Console.WriteLine("(no minions)");
                    }
                }
            }
        }

        private void PrintVillainName(SqlConnection connection, int villainId)
        {
            var cmdText = File.ReadAllText(SelectVillainByIdFilePath);
            using (var command = new SqlCommand(cmdText, connection))
            {
                command.Parameters.AddWithValue("@villainId", villainId);
                var villainName = command.ExecuteScalar();

                if (villainName == null)
                {
                    Console.WriteLine("No villain with ID 10 exists in the database.");
                    Environment.Exit(Environment.ExitCode);
                }
                else
                {
                    Console.WriteLine($"Villain: {villainName}");
                }
            }
        }

        private void ExecuteNonQueryCommand(SqlConnection connection, string commandPath)
        {
            var cmdText = File.ReadAllText(commandPath);
            using (var command = new SqlCommand(cmdText, connection))
            {
                command.ExecuteNonQuery();
            }
        }
    }
}
