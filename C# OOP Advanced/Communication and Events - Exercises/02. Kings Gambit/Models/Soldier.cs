namespace _02.Kings_Gambit.Models
{
    using System;
    using Interfaces;

    public abstract class Soldier : IPerson
    {
        public Soldier(string name, IWroiter writer)
        {
            this.Name = name;
            this.Writer = writer;
        }

        public string Name { get; private set; }

        protected IWroiter Writer { get; private set; }

        public abstract void KingUnderAttack(object sender, EventArgs e);
    }
}
