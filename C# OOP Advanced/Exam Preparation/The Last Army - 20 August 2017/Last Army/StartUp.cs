public class StartUp
{
    public static void Main()
    {
        var reader = new ConsoleReader();
        var writer = new ConsoleWriter();

        var army = new Army();
        var warehouse = new WareHouse();
        var missionController = new MissionController(army, warehouse);

        var ammunitionFactory = new AmmunitionFactory();
        var soldierFactory = new SoldierFactory();
        var missionFactory = new MissionFactory();
        var gameController = new GameController(army, 
            warehouse, 
            missionController, 
            ammunitionFactory, 
            soldierFactory, 
            missionFactory);

        var engine = new Engine(reader, writer, gameController, missionController);
        engine.Run();
    }
}