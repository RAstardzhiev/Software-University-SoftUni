namespace _08.Military_Elite.Models.Repairs
{
    using Interfaces;

    public class Repair : IRepair
    {
        private string partName;
        private int hoursWorked;

        public Repair(string partName, int hoursWorked)
        {
            this.partName = partName;
            this.hoursWorked = hoursWorked;
        }

        public string PartName { get; private set; }

        public int HoursWorked { get; private set; }

        public override string ToString()
        {
            return $"Part Name: {this.partName} Hours Worked: {this.hoursWorked}";
        }
    }
}
