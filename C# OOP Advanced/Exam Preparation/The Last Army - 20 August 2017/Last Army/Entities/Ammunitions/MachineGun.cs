public class MachineGun : Ammunition
{
    private const double WeightUnits = 10.6;

    public MachineGun(string name)
        : base(name, WeightUnits)
    {
    }
}