namespace _04.Work_Force.Models
{
    using System;
    using Interfaces;

    public class JobEventArgs : EventArgs
    {
        public JobEventArgs(IJob job)
        {
            this.Job = job;
        }

        public IJob Job { get; }
    }
}
