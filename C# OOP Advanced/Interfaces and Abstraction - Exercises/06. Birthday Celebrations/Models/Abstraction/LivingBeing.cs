namespace _06.Birthday_Celebrations.Models.Abstraction
{
    public abstract class LivingBeing : IBirthable
    {
        public LivingBeing(string birthDate, string name)
        {
            BirthDate = birthDate;
            Name = name;
        }

        public string BirthDate { get; private set; }

        public string Name { get; private set; }
    }
}
