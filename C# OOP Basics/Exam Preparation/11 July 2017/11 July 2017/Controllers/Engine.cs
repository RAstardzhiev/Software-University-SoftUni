using System;

public class Engine
{
    private CarManager manager;

    public Engine()
    {
        this.manager = new CarManager();
    }

    public void Run()
    {
        var input = Console.ReadLine();

        while (input != "Cops Are Here")
        {
            ExecuteCommand(input.Split());
            input = Console.ReadLine();
        }
    }

    private void ExecuteCommand(string[] completeCommand)
    {
        var command = completeCommand[0];
        int id;
        string type;

        switch (command)
        {
            case "register":
                id = int.Parse(completeCommand[1]);
                type = completeCommand[2];
                var brand = completeCommand[3];
                var model = completeCommand[4];
                var year = int.Parse(completeCommand[5]);
                var horsePower = int.Parse(completeCommand[6]);
                var acceleration = int.Parse(completeCommand[7]);
                var suspension = int.Parse(completeCommand[8]);
                var durability = int.Parse(completeCommand[9]);
                manager.Register(id, type, brand, model, year, horsePower, acceleration, suspension, durability);
                break;
            case "check":
                id = int.Parse(completeCommand[1]);
                Console.WriteLine(manager.Check(id));
                break;
            case "open": // open {id} {type} {length} {route} {prizePool}
                id = int.Parse(completeCommand[1]);
                type = completeCommand[2];
                var length = int.Parse(completeCommand[3]);
                var route = completeCommand[4];
                var prizePool = int.Parse(completeCommand[5]);
                manager.Open(id, type, length, route, prizePool);
                break;
            case "participate": // participate {carId} {raceId}
                var carId = int.Parse(completeCommand[1]);
                var raceId = int.Parse(completeCommand[2]);
                manager.Participate(carId, raceId);
                break;
            case "start": // start {raceId}
                id = int.Parse(completeCommand[1]);
                Console.WriteLine(manager.Start(id));
                break;
            case "park": // park {carId}
                id = int.Parse(completeCommand[1]);
                manager.Park(id);
                break;
            case "unpark": // unpark {carId}
                id = int.Parse(completeCommand[1]);
                manager.Unpark(id);
                break;
            case "tune": // tune {tuneIndex} {tuneAddOn}
                var tuneIndex = int.Parse(completeCommand[1]);
                var addOn = completeCommand[2];
                manager.Tune(tuneIndex, addOn);
                break;
            default:
                break;
        }
    }
}
