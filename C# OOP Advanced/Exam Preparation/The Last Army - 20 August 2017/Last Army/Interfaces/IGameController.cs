public interface IGameController
{
    IArmy Army { get; }

    IWareHouse WearHouse { get; }

    MissionController MissionControllerProp { get; }

    IAmmunitionFactory AmunitionFactory { get; }

    ISoldierFactory SoldierFactory { get; }

    IMissionFactory MissionFactory { get; }

    void GiveInputToGameController(string input);

    void RegenerateSoldiers(string soldiersType);
}
