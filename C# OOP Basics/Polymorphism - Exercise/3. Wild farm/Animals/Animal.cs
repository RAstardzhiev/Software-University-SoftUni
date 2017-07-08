namespace _3.Wild_farm.Animals
{
    using Foods;

    public abstract class Animal
    {
        private string name;
        private string type;
        private double weight;

        public Animal(string name, string type, double weight)
        {
            this.Name = name;
            this.Type = type;
            this.Weight = weight;
        }

        protected int FoodEaten { get; set; }

        protected string Name
        {
            get
            {
                return this.name;
            }

            private set
            {
                this.name = value;
            }
        }

        protected string Type
        {
            get
            {
                return this.type;
            }

            private set
            {
                this.type = value;
            }
        }

        protected double Weight
        {
            get
            {
                return this.weight;
            }

            private set
            {
                this.weight = value;
            }
        }

        public abstract string MakeSound();

        public abstract void Eat(Food food);
    }
}
