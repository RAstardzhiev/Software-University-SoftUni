public class Medium : Mission
{
    private const string MissionName = "Capturing dangerous criminals";
    private const int RequiredEndurance = 50;
    private const int WearLevelDecrementForEachWeapon = 50;

    public Medium(double scoreToComplete) 
        : base(MissionName, RequiredEndurance, scoreToComplete, WearLevelDecrementForEachWeapon)
    {
    }
}
