namespace _12.Google
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Person
    {
        private string name;
        private Company company;
        private Car car;
        private Queue<Pokemon> pokemons;
        private Queue<Parent> parents;
        private Queue<Child> children;

        public Person(string name)
        {
            this.Name = name;
            this.pokemons = new Queue<Pokemon>();
            this.parents = new Queue<Parent>();
            this.children = new Queue<Child>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            private set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException($"{nameof(Person)}'s name can not be neither empty nor white space!!!");
                }

                this.name = value;
            }
        }

        public void AssignACompany(Company company)
        {
            this.company = company;
        }

        public void AssignACar(Car car)
        {
            this.car = car;
        }

        public void AddInCollection(Pokemon pokemon)
        {
            this.pokemons.Enqueue(pokemon);
        }

        public void AddInCollection(Parent parent)
        {
            this.parents.Enqueue(parent);
        }

        public void AddInCollection(Child child)
        {
            this.children.Enqueue(child);
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine(this.name);

            sb.AppendLine("Company:");
            if (this.company != null)
            {
                sb.AppendLine(this.company.ToString());
            }

            sb.AppendLine("Car:");
            if (this.car != null)
            {
                sb.AppendLine(this.car.ToString());
            }

            sb.AppendLine("Pokemon:");
            if (this.pokemons.Count > 0)
            {
                sb.AppendLine(string.Join(Environment.NewLine, this.pokemons.Select(pok => pok.ToString())));
            }

            sb.AppendLine("Parents:");
            if (this.parents.Count > 0)
            {
                sb.AppendLine(string.Join(Environment.NewLine, this.parents.Select(par => par.ToString())));
            }

            sb.AppendLine("Children:");
            if (this.children.Count > 0)
            {
                sb.AppendLine(string.Join(Environment.NewLine, this.children.Select(c => c.ToString())));
            }

            return sb.ToString();
        }
    }
}
