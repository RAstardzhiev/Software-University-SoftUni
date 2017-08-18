public class Assassin : AbstractHero
{
    private const int InitialStrength = 25;
    private const int InitialAgility = 100;
    private const int InitialIntelligence = 15;
    private const int InitialHitPoints = 150;
    private const int InitialHitDamage = 300;

    public Assassin(string name) 
        : base(name, InitialStrength, InitialAgility, InitialIntelligence, InitialHitPoints, InitialHitDamage)
    {
    }
}
