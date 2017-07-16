namespace Paw_Inc___25_August_2016.Centers
{
    using Animals;
    using System.Collections.Generic;
    using System.Linq;

    public class CleansingCenter : Center
    {
        private List<Animal> cleansedStat;
        private Dictionary<string, List<Animal>> clientNameAndAnimals;

        public CleansingCenter(string name) : base(name)
        {
            this.clientNameAndAnimals = new Dictionary<string, List<Animal>>();
            this.cleansedStat = new List<Animal>();
        }

        public IReadOnlyDictionary<string, List<Animal>> ClientNameAndAnimals => this.clientNameAndAnimals as IReadOnlyDictionary<string, List<Animal>>;

        public IReadOnlyList<Animal> CleansedStat => this.cleansedStat as IReadOnlyList<Animal>;

        public int AwaitingCleansing => this.Animals.Where(a => !a.IsCleansed).Count();

        public void Cleanse()
        {
            this.clientNameAndAnimals.Clear();

            foreach (var animal in this.Animals)
            {
                animal.IsCleansed = true;
            }

            this.cleansedStat.AddRange(this.Animals);
            this.Animals.Clear();
        }

        public void AddAnimalsForCleansing(IEnumerable<Animal> animals, string adoptionCenterName)
        {
            if (animals == null)
            {
                return;
            }

            if (!this.clientNameAndAnimals.ContainsKey(adoptionCenterName))
            {
                this.clientNameAndAnimals[adoptionCenterName] = new List<Animal>();
            }

            this.clientNameAndAnimals[adoptionCenterName].AddRange(animals);
            this.Animals.AddRange(animals);
        }
    }
}