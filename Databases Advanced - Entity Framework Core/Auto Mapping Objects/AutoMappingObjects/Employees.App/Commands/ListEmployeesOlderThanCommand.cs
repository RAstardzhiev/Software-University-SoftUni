namespace Employees.App.Commands
{
    using AutoMapper;
    using Employees.App.Commands.Abstractions;
    using Employees.App.DTOs;
    using Employees.App.Interfaces;
    using Employees.Data;
    using System;
    using System.Linq;

    public class ListEmployeesOlderThanCommand : Command
    {
        private EmployeesContext context;
        private IWriter writer;

        public ListEmployeesOlderThanCommand(string[] cmdArgs, EmployeesContext context, IWriter writer) 
            : base(cmdArgs)
        {
            this.context = context;
            this.writer = writer;
        }

        // ListEmployeesOlderThan <age>
        public override void Execute()
        {
            if (this.CmdArgs.Length != 1)
            {
                throw new ArgumentException(InvalidCommandArgumentsExceptionMessage);
            }

            var age = int.Parse(this.CmdArgs[0]);

            var employees = this.context.Employees
                .Where(e => e.Birthday != null)
                .Select(e => new
                {
                    Employee = Mapper.Map<EmployeeDto>(e),
                    Manager = Mapper.Map<ManagerDto>(e.Manager),
                    Age = Math.Ceiling((DateTime.Now - e.Birthday.Value).TotalDays / 365.2422),
                    e.Salary
                })
                .Where(e => e.Age > age)
                .OrderByDescending(e => e.Salary)
                .Select(e => e.Manager == null
                    ? $"{e.Employee.FirstName} {e.Employee.LastName} - ${e.Employee.Salary:F2} - Manager: [no manager]"
                    : $"{e.Employee.FirstName} {e.Employee.LastName} - ${e.Employee.Salary:F2} - Manager: {e.Manager.LastName}")
                .ToArray();

            this.writer.WriteLine(string.Join(Environment.NewLine, employees));
        }
    }
}
