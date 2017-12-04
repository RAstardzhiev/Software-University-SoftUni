namespace Employees.App.DTOs
{
    public class EmployeeDto
    {
        public EmployeeDto(string firstName, string lastName, decimal salary)
        {
            FirstName = firstName;
            LastName = lastName;
            Salary = salary;
        }

        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public decimal Salary { get; set; }

        public override string ToString() => $"ID: {this.Id} - {this.FirstName} {this.LastName} - ${this.Salary:f2}";
    }
}
