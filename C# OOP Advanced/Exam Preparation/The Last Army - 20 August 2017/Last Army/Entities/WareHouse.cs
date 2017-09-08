using System;
using System.Collections.Generic;
using System.Linq;

public class WareHouse : IWareHouse
{
    private IDictionary<string, int> weapons;
    private IAmmunitionFactory ammunitionFactory;

    public WareHouse()
        : this(new Dictionary<string, int>(), new AmmunitionFactory())
    {
    }

    public WareHouse(IDictionary<string, int> weapons, IAmmunitionFactory ammunitionFactory)
    {
        this.weapons = weapons;
        this.ammunitionFactory = ammunitionFactory;
    }

    public void EquipArmy(IArmy army)
    {
        foreach (var soldier in army.Soldiers)
        {
            this.TryEquipSoldier(soldier);
        }
    }

    public bool TryEquipSoldier(ISoldier soldier)
    {
        bool isEquipped = true;

        List<string> missingWeapons = soldier.Weapons
            .Where(w => w.Value == null)
            .Select(w => w.Key).ToList();

        foreach (string weaponName in missingWeapons)
        {
            if (this.weapons.ContainsKey(weaponName) && this.weapons[weaponName] > 0)
            {
                soldier.Weapons[weaponName] = this.ammunitionFactory.CreateAmmunition(weaponName);
                this.weapons[weaponName]--;
            }
            else
            {
                isEquipped = false;
            }
        }

        return isEquipped;
    }

    public void AddAmmunitions(string name, int count)
    {
        if (!this.weapons.ContainsKey(name))
        {
            this.weapons[name] = 0;
        }

        this.weapons[name] += count;
    }
}
