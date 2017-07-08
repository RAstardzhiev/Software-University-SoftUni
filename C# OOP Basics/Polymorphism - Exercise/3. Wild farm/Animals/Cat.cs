namespace _3.Wild_farm.Animals
{
    using Foods;

    class Cat : Felime
    {
        private string breed;

        public Cat(string name, string type, double weight, string livingRegion, string breed) 
            : base(name, type, weight, livingRegion)
        {
            this.breed = breed;
        }

        public override void Eat(Food food)
        {
            this.FoodEaten += food.Quantity;
        }

        public override string MakeSound()
        {
            return "Meowwww";
        }

        public override string ToString()
        {
            return $"{this.Type}[{this.Name}, {this.breed}, {this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
        }
    }
}
