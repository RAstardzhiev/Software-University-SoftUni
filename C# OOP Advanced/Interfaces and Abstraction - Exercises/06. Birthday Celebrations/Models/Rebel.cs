namespace _06.Birthday_Celebrations.Models
{
    public class Rebel : Buyer
    {
        private string group;

        public Rebel(string birthDate, string name, string group) : base(birthDate, name)
        {
            this.group = group;
        }

        public override void BuyFood()
        {
            this.Food += 5;
        }
    }
}
