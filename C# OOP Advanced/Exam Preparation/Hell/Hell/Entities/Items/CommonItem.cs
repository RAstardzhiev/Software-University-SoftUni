using System;
using System.Text;

public class CommonItem : AbstractItem
{
    public CommonItem(string name, int strengthBonus, int agilityBonus, int intelligenceBonus, int hitPointsBonus, int damageBonus) 
        : base(name, strengthBonus, agilityBonus, intelligenceBonus, hitPointsBonus, damageBonus)
    {
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();

        sb.AppendLine($"###Item: {this.Name}")
            .AppendLine($"###+{this.StrengthBonus} Strength")
            .AppendLine($"###+{this.AgilityBonus} Agility")
            .AppendLine($"###+{this.IntelligenceBonus} Intelligence")
            .AppendLine($"###+{this.HitPointsBonus} HitPoints")
            .AppendLine($"###+{this.DamageBonus} Damage");

        return sb.ToString().TrimEnd();
    }
}
