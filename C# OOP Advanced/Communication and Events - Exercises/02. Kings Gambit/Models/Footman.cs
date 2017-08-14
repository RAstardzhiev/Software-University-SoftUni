namespace _02.Kings_Gambit.Models
{
    using System;
    using Interfaces;

    public class Footman : Soldier
    {
        public Footman(string name, IWroiter writer) : base(name, writer)
        {
        }

        public override void KingUnderAttack(object sender, EventArgs e)
        {
            this.Writer.WriteLine($"Footman {this.Name} is panicking!");
        }
    }
}
