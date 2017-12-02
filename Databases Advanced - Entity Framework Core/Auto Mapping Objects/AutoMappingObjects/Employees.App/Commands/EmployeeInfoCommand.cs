namespace Employees.App.Commands
{
    using AutoMapper.QueryableExtensions;
    using Employees.App.Commands.Abstractions;
    using Employees.App.DTOs;
    using Employees.App.Interfaces;
    using Employees.Data;
    using System;
    using System.Linq;

    public class EmployeeInfoCommand : Command
    {
        private const string EmployeeNotFoundExceptionMessage = "Employee with Id {0} not found";

        private EmployeesContext context;
        private IWriter writer;

        public EmployeeInfoCommand(string[] cmdArgs, EmployeesContext context, IWriter writer) 
            : base(cmdArgs)
        {
            this.context = context;
            this.writer = writer;
        }

        // EmployeeInfo <employeeId> 
        public override void Execute()
        {
            if (this.CmdArgs.Length != 1)
            {
                throw new ArgumentException(InvalidCommandArgumentsExceptionMessage);
            }

            var id = int.Parse(this.CmdArgs[0]);
            var employee = this.context.Employees
                .ProjectTo<EmployeeDto>()
                .SingleOrDefault(e => e.Id == id);

            if (employee == null)
            {
                throw new ArgumentException(string.Format(EmployeeNotFoundExceptionMessage, id));
            }

            this.writer.WriteLine(employee.ToString());
        }
    }
}
