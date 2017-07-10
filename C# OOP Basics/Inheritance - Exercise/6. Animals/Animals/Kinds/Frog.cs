namespace _6.Animals.Animals.Kinds
{
    public class Frog : Animal
    {
        public Frog(string name, int age, string gender) : base(name, age, gender)
        {
        }

        public override string ProduceSound()
        {
            return "Frogggg";
        }
    }
}
