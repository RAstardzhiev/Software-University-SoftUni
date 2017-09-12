namespace _04.Work_Force.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Reflection;
    using System.Linq;
    using Interfaces;
    using Models;
    using Models.Employees;

    public class Engine
    {
        private const string MissingEmployeeExceptionMessage = "Employee {0} is not available";
        private const string WrongParametersCountInCommandExceptionMessage = "Expected parameters are: {0}";
        private const string CommandNameSuffix = "Command";
        private const string EndCommand = "End";

        private IList<IEmployee> employees;
        private IList<IJob> jobs;

        private IReader reader;
        private IWriter writer;
        private MethodInfo[] methods;

        public Engine(IReader reader, IWriter writer)
            : this(new List<IJob>(), new List<IEmployee>(), reader, writer)
        {
        }

        public Engine(IList<IJob> jobs, IList<IEmployee> employees, IReader reader, IWriter writer)
        {
            this.employees = employees;
            this.jobs = jobs;
            this.reader = reader;
            this.writer = writer;
            this.methods = this.GetType()
                .GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
        }

        public void Run()
        {
            this.ExecuteCommands();
        }

        private void ExecuteCommands()
        {
            var inputLine = this.reader.ReadLine().Split();

            while (inputLine[0] != EndCommand)
            {
                var commandName = inputLine[0] + CommandNameSuffix;
                var methodForExecution = this.methods
                    .FirstOrDefault(m => m.Name.Equals(commandName, StringComparison.OrdinalIgnoreCase));

                if (methodForExecution != null)
                {
                    this.InvokeMethod(inputLine.Skip(1).ToArray(), methodForExecution);
                }

                inputLine = this.reader.ReadLine().Split();
            }
        }

        private void InvokeMethod(string[] cmdArgs, MethodInfo methodForExecution)
        {
            var requiredParams = methodForExecution.GetParameters();

            if (cmdArgs.Length < requiredParams.Length)
            {
                throw new ArgumentException(string.Format(WrongParametersCountInCommandExceptionMessage, 
                    string.Join(", ", requiredParams.Select(rp => rp.Name))));
            }

            var parsedParams = new object[requiredParams.Length];
            for (int i = 0; i < requiredParams.Length; i++)
            {
                var paramType = requiredParams[i].ParameterType;
                parsedParams[i] = Convert.ChangeType(cmdArgs[i], paramType);
            }

            methodForExecution.Invoke(this, parsedParams);
        }

        private void JobCommand(string jobName, int requiredHoursOfWork, string employeeName)
        {
            var assigningEmployee = this.employees.FirstOrDefault(e => e.Name == employeeName);
            if (assigningEmployee == null)
            {
                throw new ArgumentException(string.Format(MissingEmployeeExceptionMessage, employeeName));
            }

            var job = new Job(jobName, requiredHoursOfWork, assigningEmployee);
            job.JobDone += this.OnJobDone;
            this.jobs.Add(new Job(jobName, requiredHoursOfWork, assigningEmployee));
        }

        private void OnJobDone(object sender, JobEventArgs args) => this.writer.WriteLine($"Job {args.Job.Name} done!");

        private void StandartEmployeeCommand(string name) => this.employees.Add(new StandartEmployee(name));

        private void PartTimeEmployeeCommand(string name) => this.employees.Add(new PartTimeEmployee(name));

        private void StatusCommand() => this.writer.WriteLine(string.Join(Environment.NewLine,
            this.jobs.Select(j => j.ToString())));

        private void PassCommand()
        {
            foreach (var job in this.jobs)
            {
                job.Update();
            }
        }
    }
}
