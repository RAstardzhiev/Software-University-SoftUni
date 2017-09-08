using System;
using System.Linq;

public class AmmunitionFactory : IAmmunitionFactory
{
    private Type[] weaponTypes;

    public AmmunitionFactory()
    {
        this.weaponTypes = new TypeCollector().GetAllInheritingTypes<IAmmunition>();
    }

    public IAmmunition CreateAmmunition(string name)
    {
        var targetType = this.weaponTypes
            .FirstOrDefault(w => w.Name.Equals(name, StringComparison.OrdinalIgnoreCase));

        if (targetType == null)
        {
            return null;
        }

        return (IAmmunition)Activator.CreateInstance(targetType, name);
    }
}