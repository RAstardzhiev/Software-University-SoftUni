namespace _3.Wild_farm.Animals
{
    using System;
    using Foods;

    public class Tiger : Felime
    {
        public Tiger(string name, string type, double weight, string livingRegion) 
            : base(name, type, weight, livingRegion)
        {
        }

        public override void Eat(Food food)
        {
            if (food.GetType().Name != "Meat")
            {
                throw new ArgumentException($"{this.GetType().Name}s are not eating that type of food!");
            }

            this.FoodEaten += food.Quantity;
        }

        public override string MakeSound()
        {
            return "ROAAR!!!";
        }
    }
}
