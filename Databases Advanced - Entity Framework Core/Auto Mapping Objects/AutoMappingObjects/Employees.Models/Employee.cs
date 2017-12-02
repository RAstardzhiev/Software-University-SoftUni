namespace Employees.Models
{
    using System;
    using System.Text;
    using System.Collections.Generic;

    public class Employee
    {
        private Employee()
        {
        }

        public Employee(string firstName, string lastName, decimal salary)
        {
            FirstName = firstName;
            LastName = lastName;
            Salary = salary;
        }

        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public decimal Salary { get; set; }

        public string Address { get; set; }

        public DateTime? Birthday { get; set; }

        public int? ManagerId { get; set; }
        public Employee Manager { get; set; }

        public ICollection<Employee> ManagedEmployees { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"ID: {this.Id} - {this.FirstName} {this.LastName} - ${this.Salary:F2}")
                .Append("Birthday: ")
                .AppendLine(this.Birthday == null 
                    ? string.Empty
                    : this.Birthday.Value.ToString("dd-MM-yyyy"))
                .Append("Address: ")
                .AppendLine(this.Address == null
                    ? string.Empty
                    : this.Address);

            return sb.ToString();
        }
    }
}
