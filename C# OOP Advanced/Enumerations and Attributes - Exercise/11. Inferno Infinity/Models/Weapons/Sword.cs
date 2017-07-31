namespace _11.Inferno_Infinity.Models.Weapons
{
    using Enums;

    public class Sword : Weapon
    {
        private const int MaxDamage = 6;
        private const int MinDamage = 4;
        private const int GemSockets = 3;

        public Sword(string name, WeaponRarity rarity) 
            : base(name, rarity, MaxDamage, MinDamage, GemSockets)
        {
        }
    }
}
