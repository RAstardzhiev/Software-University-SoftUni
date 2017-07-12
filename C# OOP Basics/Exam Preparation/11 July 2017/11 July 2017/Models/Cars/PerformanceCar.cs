using System;
using System.Collections.Generic;

public class PerformanceCar : Car
{
    private const double PercentageHorsePowerIncreasement = 0.5;
    private const double PercentageSuspensionRemainingAfterDecreasement = 0.75;

    private List<string> addOns;

    public PerformanceCar(string brand, string model, int yearOfProduction, int horsepower, int acceleration, int suspension, int durability) 
        : base(brand, model, yearOfProduction, IncreaseHorsePower(horsepower), acceleration, DecreaseSuspension(suspension), durability)
    {
        this.addOns = new List<string>();
    }

    private static int DecreaseSuspension(int suspension)
    {
        return (int)(suspension * PercentageSuspensionRemainingAfterDecreasement);
    }

    private static int IncreaseHorsePower(int horsepower)
    {
        return horsepower + (int)(horsepower * PercentageHorsePowerIncreasement);
    }

    public override void Tune(int tuneIndex, string addOn)
    {
        this.addOns.Add(addOn);
        base.Tune(tuneIndex, addOn);
    }

    public override string ToString()
    {
        var stringifyedAddOns = this.addOns.Count == 0
            ? "Add-ons: None"
            : $"Add-ons: {string.Join(", ", this.addOns)}";

        return $"{base.ToString()}{Environment.NewLine}{stringifyedAddOns}";
    }
}
