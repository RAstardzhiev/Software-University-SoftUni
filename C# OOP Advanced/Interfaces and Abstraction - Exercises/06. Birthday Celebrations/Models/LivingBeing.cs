namespace _06.Birthday_Celebrations.Models
{
    using Interfaces;

    public abstract class LivingBeing : IBirthable
    {
        public LivingBeing(string birthDate, string name)
        {
            this.BirthDate = birthDate;
            this.Name = name;
        }

        public string BirthDate { get; private set; }

        public string Name { get; private set; }
    }
}
