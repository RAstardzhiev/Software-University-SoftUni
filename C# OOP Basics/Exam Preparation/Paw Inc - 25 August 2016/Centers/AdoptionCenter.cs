namespace Paw_Inc___25_August_2016.Centers
{
    using Animals;
    using System.Collections.Generic;
    using System.Linq;

    public class AdoptionCenter : Center
    {
        private List<Animal> adoptedAnimals;

        public AdoptionCenter(string name) : base(name)
        {
            this.adoptedAnimals = new List<Animal>();
        }

        public IReadOnlyList<Animal> AdoptedAnimals => this.adoptedAnimals as IReadOnlyList<Animal>;

        public int WaitingAdoptionCount => this.Animals.Where(a => a.IsCleansed).Count();

        public IEnumerable<Animal> GetUncleansedAnimals()
        {
            var uncleansedAnimals = this.Animals.Where(a => !a.IsCleansed);
            this.Animals = this.Animals.Where(a => a.IsCleansed).ToList();
            return uncleansedAnimals;
        }

        public void AddAnimals(IEnumerable<Animal> animals)
        {
            this.Animals.AddRange(animals);
        }

        public void AdoptAllCleansedAnimals()
        {
            this.adoptedAnimals.AddRange(this.Animals.Where(a => a.IsCleansed));
            this.Animals = this.Animals.Where(a => !a.IsCleansed).ToList();
        }

        public List<Animal> GetAllAnimals()
        {
            var allAnimals = new List<Animal>(this.Animals);
            this.Animals.Clear();
            return allAnimals;
        }
    }
}
