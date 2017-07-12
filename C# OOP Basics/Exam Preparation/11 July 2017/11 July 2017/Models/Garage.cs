using System;
using System.Collections.Generic;

public class Garage
{
    private List<int> parkedCars;

    public Garage()
    {
        this.parkedCars = new List<int>();
    }

    public IReadOnlyList<int> ParkedCars => this.parkedCars as IReadOnlyList<int>;

    public void AddCarId(int carId)
    {
        this.parkedCars.Add(carId);
    }

    internal void RemoveCarId(int carId)
    {
        this.parkedCars.Remove(carId);
    }
}
