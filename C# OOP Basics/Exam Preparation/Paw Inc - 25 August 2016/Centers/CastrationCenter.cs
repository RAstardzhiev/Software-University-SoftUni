namespace Paw_Inc___25_August_2016.Centers
{
    using Animals;
    using System.Collections.Generic;

    public class CastrationCenter : Center
    {
        private List<Animal> castratedAnimals;
        private Dictionary<string, List<Animal>> clientAnimals;

        public CastrationCenter(string name) : base(name)
        {
            this.clientAnimals = new Dictionary<string, List<Animal>>();
            this.castratedAnimals = new List<Animal>();
        }

        public IReadOnlyList<Animal> CastratedAnimals => this.castratedAnimals as IReadOnlyList<Animal>;

        public IReadOnlyDictionary<string, List<Animal>> ClientAnimals => this.clientAnimals as IReadOnlyDictionary<string, List<Animal>>;

        public void AcceptAnimals(string adoptionCenterName, List<Animal> animals)
        {
            if (!this.clientAnimals.ContainsKey(adoptionCenterName))
            {
                this.clientAnimals[adoptionCenterName] = new List<Animal>();
            }

            this.clientAnimals[adoptionCenterName].AddRange(animals);
            this.Animals.AddRange(animals);
        }

        public void Castrate()
        {
            this.clientAnimals.Clear();

            foreach (var animal in this.Animals)
            {
                animal.IsCastrated = true;
            }

            this.castratedAnimals.AddRange(this.Animals);
            this.Animals.Clear();
        }
    }
}