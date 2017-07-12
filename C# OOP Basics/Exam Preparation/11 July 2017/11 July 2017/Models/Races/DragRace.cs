using System;

public class DragRace : Race
{
    public DragRace(int length, string route, int prizePool) : base(length, route, prizePool)
    {
    }

    protected override int GetPerformancePoints(Car car)
    {
        return car.DragPerformance();
    }
}