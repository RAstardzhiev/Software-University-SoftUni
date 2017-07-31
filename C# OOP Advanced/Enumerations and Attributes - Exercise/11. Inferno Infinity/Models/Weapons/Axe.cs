namespace _11.Inferno_Infinity.Models.Weapons
{
    using Enums;

    public class Axe : Weapon
    {
        private const int MaxDamage = 10;
        private const int MinDamage = 5;
        private const int GemSockets = 4;

        public Axe(string name, WeaponRarity rarity) 
            : base(name, rarity, MaxDamage, MinDamage, GemSockets)
        {
        }
    }
}
