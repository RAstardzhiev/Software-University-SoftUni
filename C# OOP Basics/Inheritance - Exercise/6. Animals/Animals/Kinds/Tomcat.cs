namespace _6.Animals.Animals.Kinds
{
    public class Tomcat : Cat
    {
        private const string Gender = "Male";

        public Tomcat(string name, int age) : base(name, age, Gender)
        {
        }

        public override string ProduceSound()
        {
            return "Give me one million b***h";
        }
    }
}
