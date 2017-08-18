public class Wizard : AbstractHero
{
    private const int InitialStrength = 25;
    private const int InitialAgility = 25;
    private const int InitialIntelligence = 100;
    private const int InitialHitPoints = 100;
    private const int InitialHitDamage = 250;

    public Wizard(string name) 
        : base(name, InitialStrength, InitialAgility, InitialIntelligence, InitialHitPoints, InitialHitDamage)
    {
    }
}
