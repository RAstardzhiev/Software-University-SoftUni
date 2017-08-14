namespace _02.Kings_Gambit.Models
{
    using System;
    using Interfaces;

    public class King : IPerson
    {
        public event EventHandler UnderAttack;

        private IWroiter writer;

        public King(string name, IWroiter writer)
        {
            this.Name = name;
            this.writer = writer;
        }

        public string Name { get; private set; }

        public void OnUnderAttack()
        {
            this.writer.WriteLine($"King {this.Name} is under attack!");
            this.UnderAttack?.Invoke(this, new EventArgs());
        }
    }
}
