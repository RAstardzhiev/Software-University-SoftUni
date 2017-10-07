namespace _4.Add_Minion.Models
{
    public class Minion
    {
        public Minion(string name, int age, string town)
        {
            this.Name = name;
            this.Age = age;
            this.Town = town;
        }

        public string Name { get; set; }

        public int Age { get; set; }

        public string Town { get; set; }
    }
}
