namespace _6.Animals.Animals.Kinds
{
    public class Kitten : Cat
    {
        private const string Gender = "Female";

        public Kitten(string name, int age) : base(name, age, Gender)
        {
        }

        public override string ProduceSound()
        {
            return "Miau";
        }
    }
}
