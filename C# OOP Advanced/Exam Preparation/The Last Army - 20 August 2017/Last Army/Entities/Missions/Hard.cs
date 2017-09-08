public  class Hard : Mission
{
    private const string MissionName = "Disposal of terrorists";
    private const int RequiredEndurance = 80;
    private const int WearLevelDecrementForEachWeapon = 70;

    public Hard(double scoreToComplete) 
        : base(MissionName, RequiredEndurance, scoreToComplete, WearLevelDecrementForEachWeapon)
    {
    }
}
