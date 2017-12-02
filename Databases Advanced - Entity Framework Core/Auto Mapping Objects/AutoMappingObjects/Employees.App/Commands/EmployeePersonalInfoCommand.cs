namespace Employees.App.Commands
{
    using System;
    using Employees.App.Commands.Abstractions;
    using Employees.Data;
    using Employees.App.Interfaces;

    public class EmployeePersonalInfoCommand : Command
    {
        private const string EmployeeNotFoundExceptionMessage = "Employee with Id {0} not found";

        private EmployeesContext context;
        private IWriter writer;

        public EmployeePersonalInfoCommand(string[] cmdArgs, EmployeesContext context, IWriter writer) 
            : base(cmdArgs)
        {
            this.context = context;
            this.writer = writer;
        }

        // EmployeePersonalInfo <employeeId> 
        public override void Execute()
        {
            if (this.CmdArgs.Length != 1)
            {
                throw new ArgumentException(InvalidCommandArgumentsExceptionMessage);
            }

            var id = int.Parse(this.CmdArgs[0]);
            var employee = this.context.Employees.Find(id);
            if (employee == null)
            {
                throw new ArgumentException(string.Format(EmployeeNotFoundExceptionMessage, id));
            }

            this.writer.WriteLine(employee.ToString());
        }
    }
}
