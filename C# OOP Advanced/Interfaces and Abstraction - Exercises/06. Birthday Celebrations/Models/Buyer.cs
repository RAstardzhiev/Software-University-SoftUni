namespace _06.Birthday_Celebrations.Models
{
    using Interfaces;

    public abstract class Buyer : LivingBeing, IBuyer
    {
        public Buyer(string birthDate, string name) : base(birthDate, name)
        {
        }

        public int Food { get; protected set; }

        public abstract void BuyFood();
    }
}
