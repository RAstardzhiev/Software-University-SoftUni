using System;
using System.Text;

public abstract class Car
{
    private string brand;
    private string model;
    private int yearOfProduction;
    private int horsepower;
    private int acceleration;
    private int suspension;
    private int durability;

    public Car(string brand, string model, int yearOfProduction, int horsepower, int acceleration, int suspension, int durability)
    {
        this.brand = brand;
        this.model = model;
        this.yearOfProduction = yearOfProduction;
        this.horsepower = horsepower;
        this.acceleration = acceleration;
        this.suspension = suspension;
        this.durability = durability;
        this.WaitingRaces = 0;
    }

    public int WaitingRaces { get; set; }

    public string Brand => this.brand;

    public string Model => this.model;

    public virtual void Tune(int tuneIndex, string addOn)
    {
        this.horsepower += tuneIndex;
        this.suspension += tuneIndex / 2;
    }

    public int CasualPerformance() => (this.horsepower / this.acceleration) + (this.suspension + this.durability);

    public int DriftPerformance() => (this.suspension + this.durability);

    public int DragPerformance() => (this.horsepower / this.acceleration);

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine($"{this.brand} {this.model} {this.yearOfProduction}")
            .AppendLine($"{this.horsepower} HP, 100 m/h in {this.acceleration} s")
            .AppendLine($"{this.suspension} Suspension force, {this.durability} Durability");

        return sb.ToString().Trim();
    }
}
