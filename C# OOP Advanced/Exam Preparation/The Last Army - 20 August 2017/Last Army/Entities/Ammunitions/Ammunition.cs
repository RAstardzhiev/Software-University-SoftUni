using System;

public abstract class Ammunition : IAmmunition
{
    private const int WearLevelMultiplier = 100;

    public Ammunition(string name, double weight)
    {
        Name = name;
        Weight = weight;
        WearLevel = this.Weight * WearLevelMultiplier;
    }

    public string Name { get; private set; }

    public double Weight { get; private set; }

    public double WearLevel { get; private set; }

    public void DecreaseWearLevel(double wearAmount)
    {
        this.WearLevel -= wearAmount;
    }
}
