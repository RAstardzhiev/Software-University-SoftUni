public abstract class AbstractItem : IItem
{
    public AbstractItem(string name, int strengthBonus, int agilityBonus, int intelligenceBonus, int hitPointsBonus, int damageBonus)
    {
        this.Name = name;
        this.StrengthBonus = strengthBonus;
        this.AgilityBonus = agilityBonus;
        this.IntelligenceBonus = intelligenceBonus;
        this.HitPointsBonus = hitPointsBonus;
        this.DamageBonus = damageBonus;
    }

    public string Name { get; private set; }

    public int AgilityBonus { get; private set; }

    public int DamageBonus { get; private set; }

    public int HitPointsBonus { get; private set; }

    public int IntelligenceBonus { get; private set; }

    public int StrengthBonus { get; private set; }
}
