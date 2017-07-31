namespace _11.Inferno_Infinity.Controllers
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Factories;
    using Interfaces;

    public class WeaponManager
    {
        private IList<IWeapon> weapons;
        private WeaponFactory weaponFactory;

        public WeaponManager()
        {
            this.weapons = new List<IWeapon>();
            this.weaponFactory = new WeaponFactory();
        }

        internal void CreateWeapon(string weaponKind, string weaponName, string weaponRarity)
        {
            var weapon = this.weaponFactory.CreateWeapon(weaponKind, weaponName, weaponRarity);
            if (weapon != null)
            {
                this.weapons.Add(weapon);
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
