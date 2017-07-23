namespace BashSoft.IO.Commands
{
    using System;
    using Execptions;
    using Contracts;

    public abstract class Command : IExecutable
    {
        private string input;
        private string[] data;

        private Tester judge;
        private StudentsRepository repository;
        private IDirectoryManager inputOutputManager;

        public Command(string input, string[] data, Tester judge, StudentsRepository repository, IDirectoryManager inputOutputManager)
        {
            this.Input = input;
            this.Data = data;
            this.judge = judge;
            this.repository = repository;
            this.inputOutputManager = inputOutputManager;
        }
        
        public string[] Data
        {
            get { return this.data; }
            private set
            {
                if (value == null || value.Length == 0)
                {
                    throw new NullReferenceException();
                }
                this.data = value;
            }
        }  

        public string Input
        {
            get { return this.input; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new InvalidStringException();
                }
                this.input = value;
            }
        }

        protected Tester Judge
        {
            get { return this.judge; }
        }

        protected StudentsRepository Repository
        {
            get { return this.repository; }
        }

        protected IDirectoryManager InputOutputManager
        {
            get { return this.inputOutputManager; }
        }

        public abstract void Execute();
    }
}
