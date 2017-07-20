namespace _06.Birthday_Celebrations.Models
{
    public class Citizen : Buyer
    {
        private int age;

        public Citizen(string name, int age, string id, string birthDate) : base(birthDate, name)
        {
            this.age = age;
            this.Id = id;
        }

        public string Id { get; private set; }

        public override void BuyFood()
        {
            this.Food += 10;
        }
    }
}
