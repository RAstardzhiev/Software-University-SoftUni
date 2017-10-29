namespace _3.Mankind.Models
{
    using System;
    using System.Text;

    public class Worker : Human
    {
        private const string WeekSalaryTooSmallExceptionMessage = "Expected value mismatch! Argument: weekSalary";
        private const string WorkHoursPerDayValidationExceptionMessage = "Expected value mismatch! Argument: workHoursPerDay";
        private const int WorkingDaysInWeek = 5;

        private decimal weekSalary;
        private double workHoursPerDay;

        public Worker(string firstName, string lastName, decimal weekSalary, double workHoursPerDay) 
            : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public decimal WeekSalary
        {
            get => this.weekSalary;

            set
            {
                if (value <= 10)
                {
                    throw new ArgumentException(WeekSalaryTooSmallExceptionMessage);
                }

                this.weekSalary = value;
            }
        }

        public double WorkHoursPerDay
        {
            get => this.workHoursPerDay;

            set
            {
                if (value < 1 || value > 12)
                {
                    throw new ArgumentException(WorkHoursPerDayValidationExceptionMessage);
                }

                this.workHoursPerDay = value;
            }
        }

        public decimal MoneyPerHour() => this.WeekSalary * 1.0M / WorkingDaysInWeek / (decimal)this.WorkHoursPerDay;

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"First Name: {this.FirstName}")
                .AppendLine($"Last Name: {this.LastName}")
                .AppendLine($"Week Salary: {this.WeekSalary:F2}")
                .AppendLine($"Hours per day: {this.WorkHoursPerDay:F2}")
                .AppendLine($"Salary per hour: {this.MoneyPerHour():F2}");

            return sb.ToString().TrimEnd();
        }
    }
}
