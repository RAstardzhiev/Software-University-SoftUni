namespace _11.Inferno_Infinity.Models.Weapons
{
    using Enums;

    public class Knife : Weapon
    {
        private const int MaxDamage = 4;
        private const int MinDamage = 3;
        private const int GemSockets = 2;

        public Knife(string name, WeaponRarity rarity) 
            : base(name, rarity, MaxDamage, MinDamage, GemSockets)
        {
        }
    }
}
