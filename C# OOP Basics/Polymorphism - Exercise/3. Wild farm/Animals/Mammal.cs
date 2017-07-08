namespace _3.Wild_farm.Animals
{
    public abstract class Mammal : Animal
    {
        private string livingRegion;

        public Mammal(string name, string type, double weight, string livingRegion) 
            : base(name, type, weight)
        {
            this.LivingRegion = livingRegion;
        }

        protected string LivingRegion
        {
            get
            {
                return this.livingRegion;
            } 

            private set
            {
                this.livingRegion = value;
            }
        }

        public override string ToString()
        {
            return $"{this.Type}[{this.Name}, {this.Weight}, {this.livingRegion}, {this.FoodEaten}]";
        }
    }
}
