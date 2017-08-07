namespace _03BarracksFactory.Core.Commands
{
    using Attributes;
    using Contracts;

    public class ReportCommand : Command
    {
        [Inject]
        private IRepository repository;

        public ReportCommand(string[] data) : base(data)
        {
        }

        public override string Execute() => this.repository.Statistics;
    }
}
