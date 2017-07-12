using System;

public class AirMonument : Monument
{
    private int airAffinity;

    public AirMonument(string name, int airAffinity) : base(name)
    {
        this.airAffinity = airAffinity;
    }

    public override int GetAffinity()
    {
        return this.airAffinity;
    }

    public override string ToString()
    {
        return $"{this.Name}, Air Affinity: {this.airAffinity}";
    }
}
