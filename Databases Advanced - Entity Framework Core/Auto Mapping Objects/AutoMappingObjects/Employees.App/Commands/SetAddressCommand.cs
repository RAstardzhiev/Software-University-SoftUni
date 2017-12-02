namespace Employees.App.Commands
{
    using Employees.App.Commands.Abstractions;
    using Employees.Data;
    using Employees.Models;
    using System;
    using System.Linq;

    public class SetAddressCommand : Command
    {
        private const string EmployeeIdNotFoundExceptionMessage = "Employee with Id {0} not found!";

        private EmployeesContext context;

        public SetAddressCommand(string[] cmdArgs, EmployeesContext context) 
            : base(cmdArgs)
        {
            this.context = context;
        }

        // SetAddress <employeeId> <address> 
        public override void Execute()
        {
            if (this.CmdArgs.Length < 2)
            {
                throw new AggregateException(InvalidCommandArgumentsExceptionMessage);
            }

            var employeeId = int.Parse(this.CmdArgs[0]);

            var employee = this.GetEmployee(employeeId);
            var address = string.Join(" ", this.CmdArgs.Skip(1));

            employee.Address = address;
            context.SaveChanges();
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
