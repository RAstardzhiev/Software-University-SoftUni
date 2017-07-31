namespace _11.Inferno_Infinity.Controllers
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Enums;
    using Interfaces;
    using Models.Weapons;

    public class WeaponManager
    {
        private IList<IWeapon> weapons;

        public WeaponManager()
        {
            this.weapons = new List<IWeapon>();
        }

        internal void CreateWeapon(string weaponKind, string weaponName, WeaponRarity weaponRarity)
        {
            switch (weaponKind)
            {
                case "Axe":
                    this.weapons.Add(new Axe(weaponName, weaponRarity));
                    break;
                case "Sword":
                    this.weapons.Add(new Sword(weaponName, weaponRarity));
                    break;
                case "Knife":
                    this.weapons.Add(new Knife(weaponName, weaponRarity));
                    break;
                default:
                    break;
            }
        }

        internal string GetAllWeapons()
        {
            var sb = new StringBuilder();

            foreach (var gun in this.weapons)
            {
                sb.AppendLine(gun.ToString());
            }

            return sb.ToString().TrimEnd();
        }

        internal void AddGemToWeapon(string weaponName, int socketIndex, IGem gem)
            => this.GetWeapen(weaponName)?.AddGem(gem, socketIndex);

        internal void RemoveGemFromWeapon(string weaponName, int socketIndex) 
            => this.GetWeapen(weaponName)?.RemoveGem(socketIndex);

        private IWeapon GetWeapen(string weaponName) 
            => this.weapons.FirstOrDefault(w => w.Name == weaponName);
    }
}
