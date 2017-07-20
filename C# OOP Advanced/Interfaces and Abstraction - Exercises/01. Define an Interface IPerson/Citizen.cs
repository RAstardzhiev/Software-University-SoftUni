namespace _01.Define_an_Interface_IPerson
{
    using Interfaces;

    public class Citizen : IPerson
    {
        public Citizen(string name, int age, string id, string birthdate)
        {
            this.Name = name;
            this.Age = age;
            this.Id = id;
            this.Birthdate = birthdate;
        }

        public int Age { get; private set; }

        public string Birthdate { get; private set; }

        public string Id { get; private set; }

        public string Name { get; private set; }
    }
}
