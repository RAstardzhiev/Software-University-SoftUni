namespace _10.Explicit_Interfaces.Models
{
    using Interfaces;

    public class Citizen : IResident, IPerson
    {
        public Citizen(string name)
        {
            this.Name = name;
        }

        public string Name { get; private set; }

        public int Age { get; private set; }

        public string Country { get; private set; }

        string IResident.GetName()
        {
            return $"Mr/Ms/Mrs {this.Name}";
        }

        string IPerson.GetName()
        {
            return this.Name;
        }
    }
}
