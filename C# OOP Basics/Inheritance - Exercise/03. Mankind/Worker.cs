namespace _03.Mankind
{
    using System;
    using System.Text;

    public class Worker : Human
    {
        private const decimal MinWeekSalary = 10;
        private const int MinWorkingHoursPerDay = 1;
        private const int MaxWorkingHoursPerDay = 12;

        private decimal weekSalary;
        private double workHoursPerDay;

        public Worker(string firstName, string lastName, decimal weekSalary, double workHoursPerDay) 
            : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        private decimal WeekSalary
        {
            set
            {
                if (value <= MinWeekSalary)
                {
                    throw new ArgumentException($"Expected value mismatch! Argument: {nameof(weekSalary)}"); 
                }

                this.weekSalary = value;
            }
        }

        private double WorkHoursPerDay
        {
            set
            {
                if (value < MinWorkingHoursPerDay || value > MaxWorkingHoursPerDay)
                {
                    throw new ArgumentException($"Expected value mismatch! Argument: {nameof(workHoursPerDay)}");
                }

                this.workHoursPerDay = value;
            }
        }

        private decimal GetSalaryPerHour()
        {
            var salaryPerDay = this.weekSalary / 5;
            return salaryPerDay / (decimal)workHoursPerDay;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.Append(base.ToString())
                .AppendLine($"Week Salary: {this.weekSalary:F2}")
                .AppendLine($"Hours per day: {this.workHoursPerDay:F2}")
                .AppendLine($"Salary per hour: {this.GetSalaryPerHour():F2}");

            return sb.ToString();
        }
    }
}
