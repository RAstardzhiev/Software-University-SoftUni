namespace _06.Company_Roster
{
    public class Employee
    {
        private string name;
        private decimal salary;
        private string position;
        private string department;
        private string email;
        private int age;

        public Employee(string name, decimal salary, string position, string department)
        {
            this.name = name;
            this.salary = salary;
            this.position = position;
            this.department = department;
        }

        public Employee(string name, decimal salary, string position, string department, string email, int age)
            :this(name, salary, position, department)
        {
            this.email = email;
            this.age = age;
        }

        public string Name
        {
            get { return this.name; }
        }

        public decimal Salary
        {
            get { return this.salary; }
        }

        public string Department
        {
            get { return this.department; }
        }

        public string Email
        {
            get { return this.email; }
        }

        public int Age
        {
            get { return this.age; }
        }
    }
}
