using System;
using System.Linq;

public class MissionFactory : IMissionFactory
{
    private Type[] missionTypes;

    public MissionFactory()
    {
        this.missionTypes = new TypeCollector().GetAllInheritingTypes<IMission>();
    }

    public IMission CreateMission(string difficultyLevel, double neededPoints)
    {
        var targetType = this.missionTypes
            .FirstOrDefault(mt => mt.Name.Equals(difficultyLevel, StringComparison.OrdinalIgnoreCase));

        if (targetType == null)
        {
            return null;
        }

        return (IMission)Activator.CreateInstance(targetType, neededPoints);
    }
}
