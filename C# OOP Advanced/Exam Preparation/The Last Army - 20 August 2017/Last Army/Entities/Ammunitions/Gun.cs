public class Gun : Ammunition
{
    private const double WeightUnits = 1.4;

    public Gun(string name)
        : base(name, WeightUnits)
    {
    }
}