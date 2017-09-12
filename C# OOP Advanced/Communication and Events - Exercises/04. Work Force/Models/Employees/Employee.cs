namespace _04.Work_Force.Models.Employees
{
    using Interfaces;

    public abstract class Employee : IEmployee
    {
        public Employee(string name, int weeklyWorkingHours)
        {
            this.Name = name;
            this.WorkHoursPerWeek = weeklyWorkingHours;
        }

        public string Name { get; private set; }

        public int WorkHoursPerWeek { get; }
    }
}
