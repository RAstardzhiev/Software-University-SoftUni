namespace _11.Inferno_Infinity.Models.Weapons
{
    using System.Linq;
    using Enums;
    using Interfaces;

    public abstract class Weapon : IWeapon
    {
        protected Weapon(string name, WeaponRarity rarity, int maxDamage, int minDamage, int numberOfGemSockets)
        {
            this.Name = name;
            this.Rarity = rarity;
            this.MaxDamage = maxDamage * (int)rarity;
            this.MinDamage = minDamage * (int)rarity;
            this.GemSockets = new IGem[numberOfGemSockets];
        }

        public string Name { get; }

        public int MaxDamage { get; private set; }

        public int MinDamage { get; private set; }

        public WeaponRarity Rarity { get; private set; }

        public IGem[] GemSockets { get; private set; }

        public void AddGem(IGem gem, int socketIndex)
        {
            if (socketIndex < 0 || socketIndex >= this.GemSockets.Length)
            {
                return;
            }

            this.GemSockets[socketIndex] = gem;
        }

        public void RemoveGem(int socketIndex)
        {
            if (socketIndex < 0 || socketIndex >= this.GemSockets.Length)
            {
                return;
            }

            this.GemSockets[socketIndex] = null;
        }

        public override string ToString()
        {
            var strength = this.GemSockets.Where(g => g != null).Select(g => g.StrengthBonus).Sum();
            var agility = this.GemSockets.Where(g => g != null).Select(g => g.AgilityBonus).Sum();
            var vitality = this.GemSockets.Where(g => g != null).Select(g => g.VitalityBonus).Sum();

            var minDamage = this.MinDamage + (strength * 2) + agility;
            var maxDamage = this.MaxDamage + (strength * 3) + (agility * 4);

            return $"{this.Name}: {minDamage}-{maxDamage} Damage, +{strength} Strength, +{agility} Agility, +{vitality} Vitality";
        }
    }
}
