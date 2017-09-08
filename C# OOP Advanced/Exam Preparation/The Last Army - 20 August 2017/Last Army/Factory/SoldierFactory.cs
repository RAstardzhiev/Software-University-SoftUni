using System;
using System.Linq;

public class SoldierFactory : ISoldierFactory
{
    private Type[] soldierTypes;

    public SoldierFactory()
    {
        this.soldierTypes = new TypeCollector().GetAllInheritingTypes<ISoldier>();
    }

    public ISoldier CreateSoldier(string soldierTypeName, string name, int age, double experience, double endurance)
    {
        var targetType = this.soldierTypes
            .FirstOrDefault(st => st.Name.Equals(soldierTypeName, StringComparison.OrdinalIgnoreCase));

        if (targetType == null)
        {
            return null;
        }

        return (ISoldier)Activator.CreateInstance(targetType, name, age, experience, endurance);
    }
}