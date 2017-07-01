namespace _11.Pokemon_Trainer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Trainer
    {
        private string name;
        private int badges;
        private Stack<Pokemon> pokemons;

        public Trainer(string name)
        {
            this.Name = name;
            this.badges = 0;
            this.pokemons = new Stack<Pokemon>();
        }

        public Stack<Pokemon> Pokemons{ get { return this.pokemons; } }

        public string Name
        {
            get
            {
                return this.name;
            }

            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name can not be empty.");
                }

                this.name = value;
            }
        }

        public int Badges { get { return this.badges; } }

        public void AddABadge()
        {
            this.badges++;
        }

        internal void ClearDeadPokemons()
        {
            if (this.pokemons.Count > 0 && this.pokemons.Where(p => p.Health <= 0).FirstOrDefault() != null)
            {
                this.pokemons = new Stack<Pokemon>(this.pokemons.Where(p => p.Health > 0));
            }
        }
    }
}
