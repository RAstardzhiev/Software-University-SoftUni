namespace Employees.App.Commands
{
    using Employees.App.Commands.Abstractions;
    using Employees.Data;
    using Employees.Models;
    using System;
    using System.Globalization;
    using System.Linq;

    public class SetBirthdayCommand : Command
    {
        private const string DateFormat = "dd-MM-yyyy";

        private const string EmployeeIdNotFoundExceptionMessage = "Employee with Id {0} not found!";
        private const string InvalidDateExceptionMessage = "The given date is invalid! Date must be in the format " + DateFormat;
        
        private EmployeesContext context;

        public SetBirthdayCommand(string[] cmdArgs, EmployeesContext context) 
            : base(cmdArgs)
        {
            this.context = context;
        }

        // SetBirthday <employeeId> <date: "dd-MM-yyyy"> 
        public override void Execute()
        {
            if (this.CmdArgs.Length != 2)
            {
                throw new ArgumentException(InvalidCommandArgumentsExceptionMessage);
            }

            var employeeId = int.Parse(this.CmdArgs[0]);
            var dateString = this.CmdArgs[1];

            var employee = this.GetEmployee(employeeId);
            var date = this.TryParseDate(dateString);

            employee.Birthday = date;
            context.SaveChanges();
        }

        private DateTime TryParseDate(string dateString)
        {
            DateTime date;
            var isparsed = DateTime.TryParseExact(dateString, DateFormat, CultureInfo.InvariantCulture, DateTimeStyles.AssumeUniversal, out date);
            if (isparsed)
            {
                return date;
            }

            throw new ArgumentException();
        }

        private Employee GetEmployee(int employeeId)
        {
            var employee = this.context.Employees
                .SingleOrDefault(e => e.Id == employeeId);

            if (employee == null)
            {
                throw new AggregateException(string.Format(EmployeeIdNotFoundExceptionMessage, employeeId));
            }

            return employee;
        }
    }
}
