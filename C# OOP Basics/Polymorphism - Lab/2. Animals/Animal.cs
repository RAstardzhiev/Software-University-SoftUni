namespace _2.Animals
{
    public class Animal
    {
        private string name;
        private string favouriteFood;

        public Animal(string name, string favouriteFood)
        {
            this.name = name;
            this.favouriteFood = favouriteFood;
        }

        public virtual string ExplainMyself()
        {
            return $"I am {this.name} and my fovourite food is {this.favouriteFood}";
        }
    }
}
