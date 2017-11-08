namespace P02_DatabaseFirst
{
    using System;
    using System.Text;
    using System.Linq;
    using Data;
    using Data.Models;
    using System.Globalization;

    public class Engine
    {
        public void Run()
        {
            // this.EmployeesFullInformation(); // 3. Employees Full Information
            // this.EmployeeswithSalaryOver(50000); // 4. Employees with Salary Over 50 000
            // this.EmployeesFromDevelopment("Research and Development"); // 5. Employees from Research and Development
            // this.AddingNewAddressToEmployee("Vitoshka 15", 4, "Nakov"); // 6. Adding a New Address and Updating Employee
            // this.EmployeesProjects();// 7. Employees and Projects
            // this.AddressesByTown(); // 8. Addresses by Town
            // this.EmployeeById(147); // 9. Employee 147
            // this.DepartmentsWithEmployeesMoreThan(5); // 10. Departments with More Than 5 Employees
            // this.LatestProjects(10); // 11. Find Latest 10 Projects
            // this.IncreaseSalaries(12, "Engineering", "Tool Design", "Marketing", "Information Services"); // 12. Increase Salaries
            // this.FindEmployeesByFirstNameStart("Sa"); // 13. Find Employees by First Name Starting With "Sa"
            // this.DeleteProject(2); // 14. Delete Project by Id
            this.RemoveTowns("Sofia", "Seattle"); // 15.Remove Towns
        }

        private void RemoveTowns(params string[] names)
        {
            using (var context = new SoftUniContext())
            {
                foreach (var name in names)
                {
                    var town = context.Towns
                        .FirstOrDefault(t => t.Name.Equals(name, StringComparison.OrdinalIgnoreCase));

                    if (town == null)
                    {
                        Console.WriteLine($"There is not town with name: {name}");
                        continue;
                    }

                    context.Employees
                        .Where(e => e.Address.Town.TownId == town.TownId)
                        .ToList()
                        .ForEach(e => e.Address = null);

                    var addresses = context.Addresses
                        .Where(a => a.TownId == town.TownId)
                        .ToArray();

                    var addressesCount = addresses.Length;

                    context.Addresses.RemoveRange(addresses);
                    context.Towns.Remove(town);
                    context.SaveChanges();

                    string addressPluralisation = addressesCount == 1 
                        ? "address" 
                        : "addresses";

                    Console.WriteLine($"{addressesCount} {addressPluralisation} in {name} was deleted");
                }
            }
        }

        private void DeleteProject(int id)
        {
            using (var context = new SoftUniContext())
            {
                var project = context.Projects.Find(id);
                if (project != null)
                {
                    context.EmployeesProjects.RemoveRange(context.EmployeesProjects
                        .Where(ep => ep.Project == project));

                    context.Projects.Remove(project);
                    context.SaveChanges();
                }

                Console.WriteLine(string.Join(Environment.NewLine, context.Projects
                    .OrderBy(p => p.ProjectId)
                    .Take(10)
                    .Select(p => p.Name)));
            }
        }

        private void FindEmployeesByFirstNameStart(string startingWith)
        {
            using (var context = new SoftUniContext())
            {
                Console.WriteLine(string.Join(Environment.NewLine, context.Employees
                    .Where(e => e.FirstName.StartsWith(startingWith, StringComparison.OrdinalIgnoreCase))
                    .OrderBy(e => e.FirstName)
                    .ThenBy(e => e.LastName)
                    .Select(e => $"{e.FirstName} {e.LastName} - {e.JobTitle} - (${e.Salary:F2})")));
            }
        }

        private void IncreaseSalaries(decimal percentage, params string[] departments)
        {
            percentage /= 100.0M;

            using (var context = new SoftUniContext())
            {
                var employees = context.Employees
                    .Where(e => departments
                        .Any(d => d.Equals(e.Department.Name, StringComparison.OrdinalIgnoreCase)))
                    .Distinct()
                    .OrderBy(e => e.FirstName)
                    .ThenBy(e => e.LastName)
                    .ToList();

                foreach (var e in employees)
                {
                    e.Salary *= (1 + percentage);
                    Console.WriteLine($"{e.FirstName} {e.LastName} (${e.Salary:F2})");
                }

                context.SaveChanges();
            }

        }

        private void LatestProjects(int numberOfProjects)
        {
            using (var context = new SoftUniContext())
            {
                Console.WriteLine(string.Join(Environment.NewLine, context.Projects
                    .OrderByDescending(p => p.StartDate)
                    .Take(numberOfProjects)
                    .OrderBy(p => p.Name)
                    .Select(p => $"{p.Name}{Environment.NewLine}{p.Description}{Environment.NewLine}{p.StartDate.ToString("M/d/yyyy h:mm:ss tt", CultureInfo.InvariantCulture)}")));
            }
        }

        private void DepartmentsWithEmployeesMoreThan(int numberOfEmployees)
        {
            using (var context = new SoftUniContext())
            {
                var departmentSeparator = $"{Environment.NewLine}{new string('-', 10)}{Environment.NewLine}";

                Console.WriteLine(string.Join(departmentSeparator, context.Departments
                    .Where(d => d.Employees.Count > numberOfEmployees)
                    .OrderBy(d => d.Employees.Count)
                    .ThenBy(d => d.Name)
                    .Select(d => $"{d.Name} - {d.Manager.FirstName} {d.Manager.LastName}{Environment.NewLine}" +
                        $@"{string.Join(Environment.NewLine, d.Employees
                            .OrderBy(e => e.FirstName)
                            .ThenBy(e => e.LastName)
                            .Select(e => $"{e.FirstName} {e.LastName} - {e.JobTitle}"))}")));

                Console.WriteLine(new string('-', 10));
            }
        }

        private void EmployeeById(int id)
        {
            using (var context = new SoftUniContext())
            {
                var employee = context.Employees
                    .Select(e => new
                    {
                        e.EmployeeId,
                        e.FirstName,
                        e.LastName,
                        e.JobTitle,
                        Projects = e.EmployeeProjects
                            .Select(ep => ep.Project.Name)
                            .OrderBy(pn => pn)
                            .ToArray()
                    })
                    .FirstOrDefault(e => e.EmployeeId == id);

                if (employee != null)
                {
                    Console.WriteLine($"{employee.FirstName} {employee.LastName} - {employee.JobTitle}");
                    Console.WriteLine(string.Join(Environment.NewLine, employee.Projects));
                }
            }
        }

        private void AddressesByTown()
        {
            using (var context = new SoftUniContext())
            {
                Console.WriteLine(string.Join(Environment.NewLine, context.Addresses
                    .OrderByDescending(a => a.Employees.Count)
                    .ThenBy(a => a.Town.Name)
                    .ThenBy(a => a.Town.Name)
                    .Take(10)
                    .Select(a => $"{a.AddressText}, {a.Town.Name} - {a.Employees.Count} employees")));
            }
        }

        private void EmployeesProjects()
        {
            using (var context = new SoftUniContext())
            {
                var employees = context.Employees
                    .Where(e => e.EmployeeProjects
                        .Any(ep => ep.Project.StartDate.Year >= 2001 && ep.Project.StartDate.Year <= 2013))
                    .Take(30)
                    .Select(e => new
                    {
                        Employee = $"{e.FirstName} {e.LastName}",
                        Manager = $"{e.Manager.FirstName} {e.Manager.LastName}",
                        Projects = e.EmployeeProjects
                            .Select(ep => new
                            {
                                ep.Project.Name, 
                                ep.Project.StartDate,
                                ep.Project.EndDate
                            })
                    });

                foreach (var emp in employees)
                {
                    Console.WriteLine($"{emp.Employee} - Manager: {emp.Manager}");

                    foreach (var project in emp.Projects)
                    {
                        var endDate = project.EndDate?.ToString("M/d/yyyy h:mm:ss tt", CultureInfo.InvariantCulture) ?? "not finished";
                        Console.WriteLine($"--{project.Name} - {project.StartDate.ToString("M/d/yyyy h:mm:ss tt", CultureInfo.InvariantCulture)} - {endDate}");
                    }
                }
            }
        }

        private void AddingNewAddressToEmployee(string addressText, int townId, string assignee)
        {
            using (var context = new SoftUniContext())
            {
                var address = context.Addresses.FirstOrDefault(a => a.AddressText == addressText);
                if (address == null)
                {
                    address = new Address()
                    {
                        AddressText = addressText,
                        TownId = townId
                    };
                }

                foreach (var employee in context.Employees.Where(e => e.LastName == assignee))
                {
                    employee.Address = address;
                }

                context.SaveChanges();
                this.PrintFirstTenAddresses(context);
            }
        }

        private void PrintFirstTenAddresses(SoftUniContext context) 
            => Console.WriteLine(string.Join(Environment.NewLine, context.Employees
                .OrderByDescending(e => e.AddressId)
                .Take(10)
                .Select(e => e.Address.AddressText)));

        private void EmployeesFromDevelopment(string department)
        {
            using (var context = new SoftUniContext())
            {
                Console.WriteLine(string.Join(Environment.NewLine, context.Employees
                    .Where(e => e.Department.Name.Equals(department, StringComparison.OrdinalIgnoreCase))
                    .OrderBy(e => e.Salary)
                    .ThenByDescending(e => e.FirstName)
                    .Select(e => $"{e.FirstName} {e.LastName} from {department} - ${e.Salary:F2}")));
            }
        }

        private void EmployeeswithSalaryOver(int salary)
        {
            using (var context = new SoftUniContext())
            {
                Console.WriteLine(string.Join(Environment.NewLine, context.Employees
                    .Where(e => e.Salary > salary)
                    .Select(e => e.FirstName)
                    .OrderBy(e => e)));
            }
        }

        private void EmployeesFullInformation()
        {
            var sb = new StringBuilder();

            using (var context = new SoftUniContext())
            {
                foreach (var employee in context.Employees.OrderBy(e => e.EmployeeId))
                {
                    sb.AppendLine($"{employee.FirstName} {employee.LastName} {employee.MiddleName} {employee.JobTitle} {employee.Salary:F2}");
                }
            }

            System.Console.WriteLine(sb.ToString().TrimEnd());
        }
    }
}
