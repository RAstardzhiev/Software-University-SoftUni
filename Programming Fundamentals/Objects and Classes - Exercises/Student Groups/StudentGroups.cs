namespace Student_Groups
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;

    public class StudentGroups
    {
        public static void Main(string[] args)
        {
            List<Group> allGroups = new List<Group>();
            int townsCount = GetDataAndSetGroups(allGroups);
            Console.WriteLine($"Created {allGroups.Count} groups in {townsCount} towns:");
            foreach (Group group in allGroups)
            {
                // Plovdiv => st96@abv.bg, ani.k@yahoo.co.uk, ...
                Console.WriteLine($"{group.Town.Name} => {string.Join(", ", group.Students.Select(x => x.Email).ToArray())}");
            }
        }

        private static int GetDataAndSetGroups(List<Group> allGroups)
        {
            List<Town> towns = new List<Town>();
            while (true)
            {
                string command = Console.ReadLine();
                if (command.ToLower().Equals("end"))
                {
                    break;
                }

                if (command.Contains("=>"))
                {
                    // Town => Seats 
                    // e.g. Plovdiv => 5 seats
                    string[] townAndSeats = command
                        .Split('=', '>')
                        .Where(x => x.Length > 0)
                        .Select(x => x.Trim())
                        .ToArray();

                    towns.Add(new Town() { Name = townAndSeats[0], SeatsAvalable = int.Parse(townAndSeats[1].Substring(0, townAndSeats[1].IndexOf(' '))) });
                }
                else
                {
                    // Name           | Email                   | Registered Date
                    // Stefka Petrova |   st96@abv.bg           | 26-May-2016
                    string[] nameEmailDate = command
                        .Split('|')
                        .Select(x => x.Trim())
                        .ToArray();

                    towns[towns.Count - 1].Students.Add(new Student() { Name = nameEmailDate[0], Email = nameEmailDate[1], DateOfRegistration = DateTime.ParseExact(nameEmailDate[2], "d-MMM-yyyy", CultureInfo.InvariantCulture) } );
                }
            }

            allGroups = TownsToGroups(towns, allGroups);
            return towns.Count;
        }

        private static List<Group> TownsToGroups(List<Town> towns, List<Group> allGroups)
        {
            towns = OrderTownsAndDataProperly(towns);
            foreach (Town town in towns)
            {
                allGroups.Add(new Group() { Town = town } );
                foreach (Student student in town.Students)
                {
                    if (allGroups.Last().Students.Count == town.SeatsAvalable)
                    {
                        allGroups.Add(new Group() { Town = town });
                    }

                    allGroups.Last().Students.Add(student);
                }
            }

            return allGroups;
        }

        private static List<Town> OrderTownsAndDataProperly(List<Town> towns)
        {
            towns = towns.OrderBy(x => x.Name).ToList();
            foreach (Town town in towns)
            {
                town.Students = town.Students
                    .OrderBy(x => x.DateOfRegistration)
                    .ThenBy(x => x.Name)
                    .ThenBy(x => x.Email)
                    .ToList();
            }

            return towns;
        }
    }
}
