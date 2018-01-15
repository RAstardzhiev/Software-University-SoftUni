namespace _4.Add_Minion.Models
{
    public class Villain
    {
        private const string DefaultEvilnessFactor = "Evil";

        public Villain(string name) : this(name, DefaultEvilnessFactor)
        {
        }

        public Villain(string name, string evilnessFactor)
        {
            Name = name;
            EvilnessFactor = evilnessFactor;
        }

        public string Name { get; set; }

        public string EvilnessFactor { get; set; }
    }
}
