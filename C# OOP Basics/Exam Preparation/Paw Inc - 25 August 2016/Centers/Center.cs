namespace Paw_Inc___25_August_2016.Centers
{
    using Animals;
    using System.Collections.Generic;

    public abstract class Center
    {
        private string name;
        private List<Animal> animals;

        public Center(string name)
        {
            this.name = name;
            this.animals = new List<Animal>();
        }

        public string Name => this.name;

        protected List<Animal> Animals
        {
            get
            {
                return this.animals;
            }

            set
            {
                this.animals = value;
            }
        }

        public void AddAnimal(Animal animal)
        {
            this.animals.Add(animal);
        }
    }
}
