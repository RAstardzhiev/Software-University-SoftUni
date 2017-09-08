using System;
using System.Linq;
using System.Text;

public class GameController : IGameController
{
    private const string CommandSuffix = "Command";
    
    private Type[] commands;

    public GameController(IArmy army, 
        IWareHouse wearHouse, 
        MissionController missionControllerField,
        IAmmunitionFactory amunitionFactory,
        ISoldierFactory soldierFactory,
        IMissionFactory missionFactory)
    {
        this.Army = army;
        this.WearHouse = wearHouse;
        this.MissionControllerProp = missionControllerField;
        this.AmunitionFactory = amunitionFactory;
        this.SoldierFactory = soldierFactory;
        this.MissionFactory = missionFactory;
        this.commands = new TypeCollector().GetAllInheritingTypes<ICommand>();
    }

    public IArmy Army { get; private set; }

    public IWareHouse WearHouse { get; private set; }

    public MissionController MissionControllerProp { get; private set; }

    public IAmmunitionFactory AmunitionFactory { get; private set; }

    public ISoldierFactory SoldierFactory { get; private set; }

    public IMissionFactory MissionFactory { get; private set; }

    public void GiveInputToGameController(string input)
    {
        var data = input.Split();

        var commandName = data[0];
        if (commandName.Equals("Soldier", StringComparison.OrdinalIgnoreCase) &&
            data[1].Equals("Regenerate", StringComparison.OrdinalIgnoreCase))
        {
            commandName = "SoldierRegenerate";
            data = data.Skip(2).ToArray();
        }
        else
        {
            data = data.Skip(1).ToArray();
        }

        commandName += CommandSuffix;
        var commandType = this.commands
            .FirstOrDefault(c => c.Name.Equals(commandName, StringComparison.OrdinalIgnoreCase));

        var commandInstance = (ICommand)Activator.CreateInstance(commandType, data, this);
        commandInstance.Execute();
    }

    public void RegenerateSoldiers(string soldiersType) => this.Army.RegenerateTeam(soldiersType);

    public override string ToString()
    {
        this.MissionControllerProp.FailMissionsOnHold();

        var sb = new StringBuilder();
        sb.AppendLine("Results:")
            .AppendLine($"Successful missions - {this.MissionControllerProp.SuccessMissionCounter}")
            .AppendLine($"Failed missions - {this.MissionControllerProp.FailedMissionCounter}")
            .AppendLine("Soldiers:");

        foreach (var soldier in this.Army.Soldiers.OrderByDescending(s => s.OverallSkill))
        {
            sb.AppendLine(soldier.ToString());
        }

        return sb.ToString().Trim();
    }
}
