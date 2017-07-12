using System.Collections.Generic;
using System.Linq;

public class CarManager
{
    private Dictionary<int, Car> cars;
    private Dictionary<int, Race> races;
    private Garage garadge;

    public CarManager()
    {
        this.cars = new Dictionary<int, Car>();
        this.races = new Dictionary<int, Race>();
        this.garadge = new Garage();
    }

    public void Register(int id, string type, string brand, string model, int yearOfProduction, int horsepower, int acceleration, int suspension, int durability)
    {
        switch (type)
        {
            case "Performance":
                this.cars[id] = new PerformanceCar(brand, model, yearOfProduction, horsepower, acceleration, suspension, durability);
                break;
            case "Show":
                this.cars[id] = new ShowCar(brand, model, yearOfProduction, horsepower, acceleration, suspension, durability);
                break;
            default:
                break;
        }
    }

    public string Check(int id)
    {
        return cars[id].ToString();
    }

    public void Open(int id, string type, int length, string route, int prizePool)
    {
        switch (type)
        {
            case "Casual":
                this.races[id] = new CasualRace(length, route, prizePool);
                break;
            case "Drag":
                this.races[id] = new DragRace(length, route, prizePool);
                break;
            case "Drift":
                this.races[id] = new DriftRace(length, route, prizePool);
                break;
            default:
                break;
        }
    }

    public void Participate(int carId, int raceId)
    {
        if (this.garadge.ParkedCars.Contains(carId))
        {
            return;
        }

        this.cars[carId].WaitingRaces++;
        this.races[raceId].RegisterCar(this.cars[carId]);
    }

    public string Start(int id)
    {
        if (this.races[id].Participants.Count == 0)
        {
            return "Cannot start the race with zero participants.";
        }

        foreach (var car in this.races[id].Participants)
        {
            car.WaitingRaces--;
        }

        var raceWinners = races[id].ToString();
        this.races.Remove(id);

        return raceWinners;
    }

    public void Park(int id)
    {
        if (this.cars[id].WaitingRaces > 0)
        {
            return;
        }

        this.garadge.AddCarId(id);
    }

    public void Unpark(int id)
    {
        this.garadge.RemoveCarId(id);
    }

    public void Tune(int tuneIndex, string addOn)
    {
        foreach (var carId in this.garadge.ParkedCars)
        {
            this.cars[carId].Tune(tuneIndex, addOn);
        }
    }
}
