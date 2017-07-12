using System;

public class ShowCar : Car
{
    private int stars;

    public ShowCar(string brand, string model, int yearOfProduction, int horsepower, int acceleration, int suspension, int durability) 
        : base(brand, model, yearOfProduction, horsepower, acceleration, suspension, durability)
    {
        this.stars = 0;
    }

    public override void Tune(int tuneIndex, string addOn)
    {
        this.stars += tuneIndex;
        base.Tune(tuneIndex, addOn);
    }

    public override string ToString()
    {
        return $"{base.ToString()}{Environment.NewLine}{this.stars} *";
    }
}
