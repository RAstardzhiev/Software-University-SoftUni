namespace _04.Work_Force.Models
{
    using Interfaces;
    using System;

    public delegate void JobDoneEventHandler(object sender, JobEventArgs args);

    public class Job : IJob
    {
        public event JobDoneEventHandler JobDone;
        
        private int requiredHoursOfWork;
        private IEmployee employee;

        public Job(string name,int requiredHoursOfWork, IEmployee employee)
        {
            this.Name = name;
            this.requiredHoursOfWork = requiredHoursOfWork;
            this.employee = employee;
        }

        public string Name { get; private set; }

        public int RequiredHoursOfWork
        {
            get
            {
                return this.requiredHoursOfWork;
            }

            set
            {
                this.requiredHoursOfWork = value;
                if (this.requiredHoursOfWork <= 0)
                {
                    this.requiredHoursOfWork = 0;
                    Console.WriteLine($"Job {this.Name} done!");
                    this.JobDone?.Invoke(this, new JobEventArgs(this));
                }
            }
        }

        public void Update()
        {
            this.RequiredHoursOfWork -= this.employee.WorkHoursPerWeek;
        }

        public override string ToString()
        {
            return $"Job: {this.Name} Hours Remaining: {this.RequiredHoursOfWork}";
        }
    }
}
