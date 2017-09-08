using System;
using System.Collections.Generic;
using System.Linq;

public class Army : IArmy
{
    private IList<ISoldier> soldiers;

    public Army()
    {
        this.soldiers = new List<ISoldier>();
    }

    public Army(IList<ISoldier> soldiers)
    {
        this.soldiers = soldiers;
    }

    public IReadOnlyList<ISoldier> Soldiers => this.soldiers as IReadOnlyList<ISoldier>;

    public void AddSoldier(ISoldier soldier) => this.soldiers.Add(soldier);

    public void RegenerateTeam(string soldierType)
    {
        foreach (var soldier in this.Soldiers
            .Where(s => s.GetType().Name.Equals(soldierType, StringComparison.OrdinalIgnoreCase)))
        {
            soldier.Regenerate();
        }
    }
}
