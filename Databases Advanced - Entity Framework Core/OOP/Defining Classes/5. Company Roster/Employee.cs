namespace _5.Company_Roster
{
    public class Employee
    {
        private const string DefaultEmail = "n/a";
        private const int DefaultAge = -1;

        public Employee(string name, decimal salary, string position, string department)
            : this(name, salary, position, department, DefaultEmail, DefaultAge)
        {
        }

        public Employee(string name, decimal salary, string position, string department, string email)
            : this(name, salary, position, department, email, DefaultAge)
        {
        }

        public Employee(string name, decimal salary, string position, string department, int age)
            : this(name, salary, position, department, DefaultEmail, age)
        {
        }

        public Employee(string name, decimal salary, string position, string department, string email, int age)
        {
            Name = name;
            Salary = salary;
            Position = position;
            Department = department;
            Email = email;
            Age = age;
        }

        public string Name { get; set; }

        public decimal Salary { get; set; }

        public string Position { get; set; }

        public string Department { get; set; }

        public string Email { get; set; }

        public int Age { get; set; }

        public override string ToString() => $"{this.Name} {this.Salary:F2} {this.Email} {this.Age}";
    }
}
