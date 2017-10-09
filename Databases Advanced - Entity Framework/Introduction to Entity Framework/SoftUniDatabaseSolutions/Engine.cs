namespace Introduction_to_Entity_Framework
{
    using Introduction_to_Entity_Framework.Models;
    using System;
    using System.Diagnostics;
    using System.Globalization;
    using System.IO;
    using System.Linq;

    public class Engine
    {
        public void Run()
        {
            using (SoftuniContext context = new SoftuniContext())
            {
                // this.PrintEmployeesFullInformation(context); // 3. Employees Full Information
                // this.PrintEmployeesWithSalaryOver(50000, context); // 4. Employees with Salary Over 50 000
                // this.PrintEmployeesByDepartment("Research and Development", context); // 5. Employees from Research and Development
                // this.AssignANewAddress("Nakov", "Vitoshka 15", 4, context); // 6. Adding a New Address and Updating Employee
                // this.PrintFirsttTenEmployeesOrderedDescendingById(context); // 6. Adding a New Address and Updating Employee
                // this.PrintTopThirtyEmployeesAccordingProjectStartdate(2001, 2003, context); // 7. Find Employees in Period
                // this.PrintAddressesByTownName(context); // 8. Addresses by Town Name 
                // this.PrintEmployeeProjectsById(147, context); // 9. Employee with id 147 
                // this.PrintDepartmentsWithEmployeesMoreThan(5, context); // 10. Departments with more than 5 employees
                // this.PrintLatestStartedProjects(10, context); // 11. Find Latest 10 Projects
                // this.IncreaseSalariesByDepartment(12, context, "Engineering", "Tool Design", "Marketing", "Information Services"); // 12. Increase Salaries
                // this.PrintEmployeesWhoseFirstNameStartsWith("SA", context); // 13. Find Employees by First Name Starting with ‘SA’
                // this.DeleteProject(2, context); // 15. Delete Project by Id
                // this.PrintFirstTenProjects(context); // 15. Delete Project by Id
                // this.RemoveTown("Sofia", context); // 16. Remove Towns
                this.TestLinqVsSqlCommand(context); // 17. *Native SQL Query
            }
        }

        private void TestLinqVsSqlCommand(SoftuniContext context)
        {
            Stopwatch watch = new Stopwatch();

            // Connection before the test makes the result real
            context.Projects.Count(); // Just for initializing the connection

            watch.Start();
            LINQsQuery(context);
            watch.Stop();
            Console.WriteLine($"Ticks: {watch.Elapsed.Ticks}");
            Console.WriteLine($"Milliseconds: {watch.Elapsed.Milliseconds}");

            Console.WriteLine();
            watch.Reset();
            watch.Start();
            NativeSQLWithMyQuery(context);
            watch.Stop();
            Console.WriteLine($"Ticks: {watch.Elapsed.Ticks}");
            Console.WriteLine($"Milliseconds: {watch.Elapsed.Milliseconds}");

            Console.WriteLine();
            watch.Reset();
            watch.Start();
            NativeSQLWithLINQsGeneratedQuery(context);
            watch.Stop();
            Console.WriteLine($"Ticks: {watch.Elapsed.Ticks}");
            Console.WriteLine($"Milliseconds: {watch.Elapsed.Milliseconds}");

            Console.WriteLine();
            watch.Reset();
            watch.Start();
            NativeSQLWithMyQueryFromFile(@"..\..\Employees selection query.sql", context);
            watch.Stop();
            Console.WriteLine($"Ticks: {watch.Elapsed.Ticks}");
            Console.WriteLine($"Milliseconds: {watch.Elapsed.Milliseconds}");
        }

        private void NativeSQLWithMyQueryFromFile(string queryPath, SoftuniContext context)
        {
            var sql = File.ReadAllText(queryPath);
            var foundEmployees = context.Database.SqlQuery<string>(sql).ToArray();
            Console.WriteLine($"SQL with my query from FILE Found employees: {foundEmployees.Length}");
        }

        private void NativeSQLWithLINQsGeneratedQuery(SoftuniContext context)
        {
            var sql = @"
                SELECT [Extent1].[FirstName] AS [FirstName]
                FROM [dbo].[Employees] AS [Extent1]
                WHERE EXISTS
                (
                    SELECT 1 AS [C1]
                    FROM [dbo].[EmployeesProjects] AS [Extent2]
                         INNER JOIN [dbo].[Projects] AS [Extent3] ON [Extent3].[ProjectID] = [Extent2].[ProjectID]
                    WHERE([Extent1].[EmployeeID] = [Extent2].[EmployeeID])
                         AND (2002 = (DATEPART(year, [Extent3].[StartDate])))
                );
                ";

            var foundEmployees = context.Database.SqlQuery<string>(sql).ToArray();

            Console.WriteLine($"SQL with LINQ query Found employees: {foundEmployees.Length}");
        }

        private void NativeSQLWithMyQuery(SoftuniContext context)
        {
            var sql = @"
                SELECT FirstName
                FROM
                (
                    SELECT DISTINCT
                           e.EmployeeID,
                           e.FirstName
                    FROM Employees AS e
                         JOIN EmployeesProjects AS ep ON ep.EmployeeID = e.EmployeeID
                         JOIN Projects AS p ON p.ProjectID = ep.ProjectID
                    WHERE DATEPART(YEAR, p.StartDate) = 2002
                ) AS EmployeeIdNameSelection;
                ";

            var foundEmployees = context.Database.SqlQuery<string>(sql).ToArray();

            Console.WriteLine($"SQL with my query Found employees: {foundEmployees.Length}");
        }

        private void LINQsQuery(SoftuniContext context)
        {
            var foundEmployees = context.Employees
                .Where(e => e.Projects.Any(p => p.StartDate.Year == 2002))
                .Select(e => e.FirstName)
                .ToArray();

            Console.WriteLine($"LINQ Found employees: {foundEmployees.Length}");
        }

        private void RemoveTown(string townName, SoftuniContext context)
        {
            var deletingTown = context.Towns
                .FirstOrDefault(t => t.Name.Equals(townName, StringComparison.OrdinalIgnoreCase));
            if (deletingTown == null)
            {
                Console.WriteLine($"Town {townName} not found.");
                return;
            }

            foreach (var employee in context.Employees.Where(e => e.Address.TownID == deletingTown.TownID))
            {
                employee.Address = null;
            }

            var deletingAddresses = context.Addresses
                .Where(a => a.TownID == deletingTown.TownID).ToArray();
            context.Addresses.RemoveRange(deletingAddresses);
            context.Towns.Remove(deletingTown);
            context.SaveChanges();

            Console.WriteLine($"{deletingAddresses.Length} address in {deletingTown.Name} was deleted");
        }

        private void PrintFirstTenProjects(SoftuniContext context) 
            => Console.WriteLine(string.Join(Environment.NewLine, context.Projects
                .Take(10)
                .Select(p => p.Name)));

        private void DeleteProject(int projectId, SoftuniContext context)
        {
            var project = context.Projects.Find(projectId);
            if (project == null)
            {
                return;
            }

            foreach (var employee in context.Employees.Where(e => e.Projects.Any(p => p.ProjectID == projectId)))
            {
                employee.Projects.Remove(project);
            }

            context.Projects.Remove(project);
            context.SaveChanges();
        }

        private void PrintEmployeesWhoseFirstNameStartsWith(string key, SoftuniContext context)
        {
            foreach (var employee in context.Employees
                .Where(e => e.FirstName.StartsWith(key)))
            {
                Console.WriteLine($"{employee.FirstName} {employee.LastName} - {employee.JobTitle} - (${employee.Salary:F4})");
            }
        }

        private void IncreaseSalariesByDepartment(int percentageIncreasement, SoftuniContext context, params string[] departmentNames)
        {
            var employees = context.Employees
                .Where(e => departmentNames.Contains(e.Department.Name));

            foreach (var employee in employees)
            {
                employee.Salary *= 1.12M;
            }

            context.SaveChanges();

            foreach (var employee in employees)
            {
                Console.WriteLine($"{employee.FirstName} {employee.LastName} (${employee.Salary:F6})");
            }
        }

        private void PrintLatestStartedProjects(int numberOfProjects, SoftuniContext context)
        {
            foreach (var project in context.Projects
                .OrderByDescending(p => p.StartDate)
                .Take(numberOfProjects)
                .OrderBy(p => p.Name))
            {
                Console.WriteLine($"{project.Name} {project.Description} " +
                    $"{project.StartDate.ToString("M/d/yyyy h:mm:ss tt", CultureInfo.InvariantCulture)} " +
                    $"{project.EndDate?.ToString("M/d/yyyy h:mm:ss tt", CultureInfo.InvariantCulture)}");
            }
        }

        private void PrintDepartmentsWithEmployeesMoreThan(int empMoreThan, SoftuniContext context)
        {
            foreach (var department in context.Departments
                .Where(d => d.Employees.Count > empMoreThan)
                .OrderBy(d => d.Employees.Count))
            {
                Console.WriteLine($"{department.Name} {department.Manager.FirstName}");
                foreach (var employee in department.Employees)
                {
                    Console.WriteLine($"{employee.FirstName} {employee.LastName} {employee.JobTitle}");
                }
            }
        }

        private void PrintEmployeeProjectsById(int employeeId, SoftuniContext context)
        {
            var employee = context.Employees
                .FirstOrDefault(e => e.EmployeeID == employeeId);

            if (employee == null)
            {
                Console.WriteLine($"There is not an employee with Id {employeeId}");
                return;
            }

            Console.WriteLine($"{employee.FirstName} {employee.LastName} {employee.JobTitle}");
            Console.WriteLine(string.Join(Environment.NewLine, employee.Projects
                .Select(p => p.Name)
                .OrderBy(pn => pn)));
        }

        private void PrintAddressesByTownName(SoftuniContext context)
        {
            foreach (var address in context.Addresses
                .OrderByDescending(a => a.Employees.Count)
                .ThenBy(a => a.Town.Name)
                .Take(10))
            {
                Console.WriteLine($"{address.AddressText}, {address.Town.Name} - {address.Employees.Count} employees");
            }
        }

        private void PrintTopThirtyEmployeesAccordingProjectStartdate(int minYear, int maxYear, SoftuniContext context)
        {
            foreach (var employee in context.Employees
                .Where(e => e.Projects.Any(p => p.StartDate.Year >= minYear) && 
                    e.Projects.Any(p => p.StartDate.Year <= maxYear))
                .Take(30))
            {
                Console.WriteLine($"{employee.FirstName} {employee.LastName} {employee.Manager.FirstName}");
                Console.Write("--");
                Console.WriteLine(string.Join($"{Environment.NewLine}--", employee.Projects
                    .Select(p => $"{p.Name} {p.StartDate.ToString("M/d/yyyy h:mm:ss tt", CultureInfo.InvariantCulture)} {p.EndDate?.ToString("M/d/yyyy h:mm:ss tt", CultureInfo.InvariantCulture)}")));
            }
        }

        private void PrintFirsttTenEmployeesOrderedDescendingById(SoftuniContext context) 
            => Console.WriteLine(string.Join(Environment.NewLine, context.Employees
                .OrderByDescending(e => e.AddressID)
                .Take(10)
                .Select(e => e.Address.AddressText)));

        private void AssignANewAddress(string familyToAssignNewAddress, string newAddressText, int townId, SoftuniContext context)
        {
            var newAddress = new Address()
            {
                AddressText = newAddressText, 
                TownID = townId
            };

            foreach (var employee in context
                .Employees.Where(e => e.LastName == familyToAssignNewAddress))
            {
                employee.Address = newAddress;
            }

            context.SaveChanges();
        }

        private void PrintEmployeesByDepartment(string keyDepartmentName, SoftuniContext context)
        {
            foreach (var employee in context.Employees
                .Where(e => e.Department.Name == keyDepartmentName)
                .OrderBy(e => e.Salary)
                .ThenByDescending(e => e.FirstName))
            {
                Console.WriteLine($"{employee.FirstName} {employee.LastName} from {keyDepartmentName} - ${employee.Salary:F2}");
            }
        }

        private void PrintEmployeesWithSalaryOver(int salary, SoftuniContext context) 
            => Console.WriteLine(string.Join(Environment.NewLine, context.Employees
                .Where(e => e.Salary > salary)
                .Select(e => e.FirstName)));

        private void PrintEmployeesFullInformation(SoftuniContext context)
        {
            foreach (var e in context.Employees.OrderBy(e => e.EmployeeID))
            {
                Console.WriteLine($"{e.FirstName} {e.LastName} {e.MiddleName} {e.JobTitle} {e.Salary}");
            }
        }
    }
}
