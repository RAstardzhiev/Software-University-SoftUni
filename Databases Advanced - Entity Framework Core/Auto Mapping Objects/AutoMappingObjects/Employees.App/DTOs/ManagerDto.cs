namespace Employees.App.DTOs
{
    using AutoMapper;
    using Employees.Models;
    using System.Collections.Generic;
    using System.Text;

    public class ManagerDto
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public ICollection<Employee> ManagedEmployees { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"{this.FirstName} {this.LastName} | Employees: {this.ManagedEmployees.Count}");

            foreach (var employee in this.ManagedEmployees)
            {
                var dto = Mapper.Map<EmployeeDto>(employee);
                sb.AppendLine($"    - {dto.FirstName} {dto.LastName} - ${dto.Salary:F2}");
            }

            return sb.ToString();
        }
    }
}
