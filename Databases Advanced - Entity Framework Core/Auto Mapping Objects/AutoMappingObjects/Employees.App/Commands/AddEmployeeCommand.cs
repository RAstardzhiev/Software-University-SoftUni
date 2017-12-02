namespace Employees.App.Commands
{
    using System;
    using Employees.App.Commands.Abstractions;
    using Employees.App.DTOs;
    using Employees.Data;
    using AutoMapper;
    using Employees.Models;

    public class AddEmployeeCommand : Command
    {
        private EmployeesContext context;

        public AddEmployeeCommand(string[] cmdArgs, EmployeesContext context)
            : base(cmdArgs)
        {
            this.context = context;
        }

        // adds a new Employee to the database
        // AddEmployee <firstName> <lastName> <salary>
        public override void Execute()
        {
            if (this.CmdArgs.Length != 3)
            {
                throw new ArgumentException(InvalidCommandArgumentsExceptionMessage);
            }

            var firstName = this.CmdArgs[0];
            var lastName = this.CmdArgs[1];
            var salary = decimal.Parse(this.CmdArgs[2]);

            var dto = new EmployeeDto(firstName, lastName, salary);
            var employee = Mapper.Map<Employee>(dto);

            this.context.Employees.Add(employee);
            this.context.SaveChanges();
        }
    }
}
