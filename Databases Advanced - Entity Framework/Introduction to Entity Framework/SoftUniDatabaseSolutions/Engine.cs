namespace Introduction_to_Entity_Framework
{
    using Introduction_to_Entity_Framework.Models;
    using System;
    using System.Globalization;
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
                this.PrintEmployeesWhoseFirstNameStartsWith("SA", context); // 13. Find Employees by First Name Starting with ‘SA’
            }
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
