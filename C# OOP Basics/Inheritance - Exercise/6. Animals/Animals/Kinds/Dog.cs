namespace _6.Animals.Animals.Kinds
{
    public class Dog : Animal
    {
        public Dog(string name, int age, string gender) : base(name, age, gender)
        {
        }

        public override string ProduceSound()
        {
            return "BauBau";
        }
    }
}
