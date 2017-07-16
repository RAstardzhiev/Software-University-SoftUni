namespace Paw_Inc___25_August_2016.Animals
{
    public abstract class Animal
    {
        private string name;
        private int age;

        public Animal(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public bool IsCleansed { get; set; }

        public bool IsCastrated { get; set; }

        public string Name => this.name;
    }
}
