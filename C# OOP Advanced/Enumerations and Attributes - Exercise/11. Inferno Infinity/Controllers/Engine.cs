namespace _11.Inferno_Infinity.Controllers
{
    using System;
    using System.Linq;
    using Enums;

    public class Engine
    {
        private WeaponManager manager;
        private GemFactory gemFactory;

        public Engine()
        {
            this.manager = new WeaponManager();
            this.gemFactory = new GemFactory();
        }

        public void Run()
        {
            var command = Console.ReadLine().Split(';');

            while (command[0] != "END")
            {
                switch (command[0])
                {
                    case "Create":
                        this.ParseCommandForCreatingWeapon(command.Skip(1).ToArray());
                        break;
                    case "Add":
                        this.ParseCommandForAddingGemToWeapon(command.Skip(1).ToArray());
                        break;
                    case "Remove":
                        this.ParseCommandForRemovingGemFromWeapon(command.Skip(1).ToArray());
                        break;
                    case "Print":

                    default:
                        break;
                }

                command = Console.ReadLine().Split(';');
            }

            Console.WriteLine(this.manager.GetAllWeapons());
        }

        private void ParseCommandForRemovingGemFromWeapon(string[] cmd)
        {
            var weaponName = cmd[0];
            var socketIndex = int.Parse(cmd[1]);
            this.manager.RemoveGemFromWeapon(weaponName, socketIndex);
        }

        private void ParseCommandForAddingGemToWeapon(string[] cmd)
        {
            var weaponName = cmd[0];
            var socketIndex = int.Parse(cmd[1]);
            var gemType = cmd[2].Split();
            var gem = this.gemFactory.CreateGem(gemType[1], gemType[0]);

            if (gem == null)
            {
                return;
            }

            this.manager.AddGemToWeapon(weaponName, socketIndex, gem);
        }

        private void ParseCommandForCreatingWeapon(string[] cmd)
        {
            var weaponName = cmd[1];
            var weaponType = cmd[0].Split();
            var weaponKind = weaponType[1];
            WeaponRarity weaponRarity;
            var isRarityValid = Enum.TryParse(weaponType[0], out weaponRarity);

            if (!isRarityValid)
            {
                return;
            }

            this.manager.CreateWeapon(weaponKind, weaponName, weaponRarity);
        }
    }
}
